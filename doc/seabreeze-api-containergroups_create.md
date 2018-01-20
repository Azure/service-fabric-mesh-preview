---
title: "Create"
ms.date: "2018-01-20"
ms.prod: "azure"
ms.service: "SeaBreeze"
ms.topic: "reference"
applies_to: 
  - "Azure"
dev_langs: 
  - "rest-api"
helpviewer_keywords: 
  - "SeaBreeze Resource Provider API Reference"
---
# Create
Creates or updates the container group with the specified name and description.

Creates a container group with the specified name and description. If a container group with the same name already exists, then its description are updated to the one indicated in this request.

## Request
| Method | Request URI |
| ------ | ----------- |
| PUT | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroups/{containerGroupName}?api-version=2017-11-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [subscriptionId](#subscriptionid) | string | Yes | Path |
| [resourceGroupName](#resourcegroupname) | string | Yes | Path |
| [containerGroupName](#containergroupname) | string | Yes | Path |
| [api-version](#api-version) | string | Yes | Query |
| [containerGroup](#containergroup) | [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) | Yes | Body |

____
### subscriptionId
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The customer subscription identifier

____
### resourceGroupName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Azure resource group name

____
### containerGroupName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the container group.

____
### api-version
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: 2017-11-01-privatepreview <br/>
<br/>
The version of the API. This is a required parameter and it's value must be "2017-11-01-privatepreview".

____
### containerGroup
__Type__: [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) <br/>
__Required__: Yes<br/>
<br/>
The description of the container group to be created or updated.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | Ok<br/> | [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) |
| 201 (Created) | Created<br/> | [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ContainerGroupsCreateOrUpdate

#### Request
```
PUT https://management.azure.com/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroups/demo1?api-version=2017-11-01-privatepreview
```

##### Body
```json
{
  "id": "/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroups/demo1",
  "location": "west us",
  "name": "demo1",
  "properties": {
    "containers": [
      {
        "name": "demo1",
        "properties": {
          "command": null,
          "environmentVariables": [],
          "image": "nginx",
          "instanceView": {},
          "ports": [
            {
              "port": "80"
            }
          ],
          "resources": {
            "limits": null,
            "requests": {
              "cpu": "1",
              "memoryInGb": "1.5"
            }
          },
          "volumeMounts": null
        }
      }
    ],
    "imageRegistryCredentials": null,
    "ipAddress": {
      "type": "Public"
    },
    "osType": "Linux",
    "provisioningState": null,
    "restartPolicy": null,
    "state": null
  },
  "resourceGroup": "demo",
  "tags": null,
  "type": "Microsoft.ServiceFabric/containerGroups"
}
```

#### 200 Response
##### Body
```json
{
  "id": "/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroups/demo1",
  "location": "WestUs",
  "name": "demo1",
  "properties": {
    "containers": [
      {
        "name": "demo1",
        "properties": {
          "command": null,
          "environmentVariables": [],
          "image": "nginx",
          "instanceView": null,
          "ports": [
            {
              "port": "80"
            }
          ],
          "resources": {
            "limits": null,
            "requests": {
              "cpu": "1",
              "memoryInGb": "1.5"
            }
          },
          "volumeMounts": null
        }
      }
    ],
    "imageRegistryCredentials": null,
    "ipAddress": {
      "ip": "10.0.0.1",
      "ports": [
        {
          "port": "80",
          "protocol": "TCP"
        }
      ]
    },
    "osType": "Linux",
    "provisioningState": "Succeeded",
    "restartPolicy": null,
    "state": null,
    "volumes": null
  },
  "resourceGroup": "demo",
  "tags": null,
  "type": "Microsoft.ServiceFabric/containerGroups"
}
```

