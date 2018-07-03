
function init() {
    initDataTable();
    initWebSocket();
}

function initDataTable() {
    var jsonData = [
    ];
    loadTable(
        'data-table', 
        ['type', 'version', 'count'], 
        jsonData);
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


function onNewDataReceived(jsonString) {
    try {
        jsonData = JSON.parse(jsonString);
        loadTable(
            'data-table', 
            ['type', 'version', 'counts'], 
            jsonData);
    }
    catch (err) {
        newNodes = null;
    }
}

function loadTable(tableId, fields, data) {
    var rows = '';
    $.each(data, function(index, item) {
        var row = '<tr>';
        $.each(fields, function(index, field) {
            row += '<td>' + item[field+''] + '</td>';
        });
        rows += row + '<tr>';
    });
    $('#' + tableId).html(rows);
}