var newDataReceived = false;
var jsonData = "";

var triangles = new Array();
var triangleHistories = new Array();

function onNewDataReceived(jsonString) {
    jsonData = jsonString;
    newDataReceived = true;
}

function drawScene() {

    if (newDataReceived) {

        var newNodes = null;
        try {
            newNodes = JSON.parse(jsonData);
        }
        catch (err) {
            newNodes = null;
        }

        if (newNodes == null) {
            return;
        }

        var numNewNodes = newNodes.length;
        var newNodesTracker = new Array();
        for (newNodesIndex = 0; newNodesIndex < numNewNodes; ++newNodesIndex) {
            var newNodeEntry = newNodes[newNodesIndex];
            newNodesTracker[newNodeEntry.id] = newNodeEntry.node;

            var currentTriangle = triangles[newNodeEntry.id];
            if (currentTriangle == null) {

                // new object
                // create new triangle
                createTriangles(newNodeEntry);
            } else {

                // existing oject
                // update existing triangle
                updateTriangles(newNodeEntry);
            }
        }


        if (Object.keys(triangles).length != numNewNodes) {
            // remove the extra nodes
            var newTriangles = new Array();
            var newTriangleHistories = new Array();

        
            for (var key in triangles) {
                if (triangles.hasOwnProperty(key)) {

                    if (newNodesTracker[key] == null) {

                        removeTriangles(key);
                    } else {

                        newTriangles[key] = triangles[key];
                        newTriangleHistories[key] = triangleHistories[key]; 
                    }
                } 
            }

            triangles = newTriangles;
            triangleHistories = newTriangleHistories;
        }

        // wait for the new data to be received before repainting
        newDataReceived = false;
    }
}

function createTriangles(nodeEntry) {
    var nodeId = nodeEntry.id;
    var node = nodeEntry.node;

    var t = new Path.RegularPolygon(new Point(0, 0), 3, 20);
    t.fillColor = new Color(node.currentColor.r, node.currentColor.g, node.currentColor.b);
    triangles[nodeId] = t;

    var numHistory = node.history.length;
    triangleHistories[nodeId] = new Array();

    for (historyEntry = 0; historyEntry < numHistory; ++historyEntry) {
        var h = new Path.RegularPolygon(new Point(0, 0), 3, (20 - (2 * (numHistory - historyEntry))));
        h.fillColor = new Color(node.currentColor.r, node.currentColor.g, node.currentColor.b);
        h.fillColor.alpha = 1 - (0.11 * (numHistory - historyEntry));
        triangleHistories[nodeId][historyEntry] = h;
    }
}

function removeTriangles(nodeId) {

    var t = triangles[nodeId];
    t.fillColor = 'black';
    t.remove();
   
    if (triangleHistories[nodeId] != null) {
        var histories = triangleHistories[nodeId];
        var numHistory = histories.length;
        for (historyEntry = 0; historyEntry < numHistory; ++historyEntry) {
            var h = triangleHistories[nodeId][historyEntry];
            h.fillColor = 'black';
            h.remove();
        }
    }
}

function updateTriangles(nodeEntry) {
    var nodeId = nodeEntry.id;
    var node = nodeEntry.node;

    triangles[nodeId].position = scalePosToViewport(node.current.x, node.current.y);
    triangles[nodeId].rotation = node.rotation;

    var numHistory = node.history.length;
    var currentHistoryCount = Object.keys(triangleHistories[nodeId]).length;

    if (numHistory != currentHistoryCount) {

        // remove existing history and recreate the history
        for (historyEntry = 0; historyEntry < currentHistoryCount; ++historyEntry) {
            var historyTriangle = triangleHistories[nodeId][historyEntry];
            historyTriangle.currentColor = 'black';
            historyTriangle.remove();
        }

        triangleHistories[nodeId] = new Array();
        for (historyEntry = 0; historyEntry < numHistory; ++historyEntry) {
            var h = new Path.RegularPolygon(new Point(0, 0), 3, (20 - (2 * (numHistory - historyEntry))));
            h.fillColor = new Color(node.currentColor.r, node.currentColor.g, node.currentColor.b);
            h.fillColor.alpha = 1 - (0.11 * (numHistory - historyEntry));
            triangleHistories[nodeId][historyEntry] = h;
        }

    } else {
        // update history
        for (historyEntry = 0; historyEntry < numHistory; ++historyEntry) {
            var historyNodeData = node.history[historyEntry];
            var historyTriangle = triangleHistories[nodeId][historyEntry];
            historyTriangle.position = scalePosToViewport(historyNodeData.x, historyNodeData.y);
            historyTriangle.rotation = node.rotation;
        }
    }
}

function scalePosToViewport(nodex, nodey) {
    var xfactor = view.viewSize.width / 2;
    var yfactor = view.viewSize.height / 2;

    var xval = nodex + 1;
    var yval = nodey + 1;

    //scaling factor is width or height over 2.
    //2 = width or height, 0 = 0;

    return new Point(xval * xfactor, yval * yfactor);
}

function startDrawing() {
    var canvas = document.getElementById("canvas");

    canvas.style.border = "#00ff00 3px solid";

    paper.install(window);
    paper.setup('canvas');

    initWebSocket();

    view.onFrame = function (event) {
        drawScene();
    }
}


var websocket;

function initWebSocket() {
    websocket = new WebSocket("ws://" + window.location.host + "/data");

    websocket.onopen = function () { };

    websocket.onmessage = function (args) {
        onNewDataReceived(args.data);
    };

    websocket.onclose = function (args) {
        setTimeout(initWebSocket, 100);
    };

    websocket.onerror = function (error) {
        websocket.close();
    }
}