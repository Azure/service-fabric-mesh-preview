---
title: "Get"
ms.date: "2018-01-23"
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
# Get
Gets the properties of the specified container group.

The operation returns the properties of the container group including containers, image registry credentials,
  restart policy, IP address type, OS type, state, and volumes.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroupSets/{containerGroupSetName}/instances/{containerGroupInstanceName}?api-version=2017-11-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [subscriptionId](#subscriptionid) | string | Yes | Path |
| [resourceGroupName](#resourcegroupname) | string | Yes | Path |
| [containerGroupSetName](#containergroupsetname) | string | Yes | Path |
| [containerGroupInstanceName](#containergroupinstancename) | string | Yes | Path |
| [api-version](#api-version) | string | Yes | Query |

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
### containerGroupSetName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the container group set.

____
### containerGroupInstanceName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the of the container group.

____
### api-version
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: 2017-11-01-privatepreview <br/>
<br/>
The version of the API. This is a required parameter and it's value must be "2017-11-01-privatepreview".

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | OK<br/> | [ContainerGroupInstanceDescription](seabreeze-model-containergroupinstancedescription.md) |


## Examples

### ContainerGroupInstancesGet

#### Request
```
GET https://management.azure.com/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroupSets/demo1/instances/demo1_0?api-version=2017-11-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "id": "/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroupSets/demo1/instances/demo1_0",
  "location": "WestUs",
  "name": "demo1_0",
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
          "volumeMounts": [
            {
              "mountPath": "/mnt/volume1",
              "name": "volume1",
              "readOnly": false
            }
          ]
        }
      }
    ],
    "imageRegistryCredentials": [
      {
        "password": null,
        "server": "azcloudconsoleregistry.azurecr.io",
        "username": "azcloudconsoleregistry"
      }
    ],
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
    "volumes": [
      {
        "azureFile": {
          "readOnly": null,
          "shareName": "share1",
          "storageAccountKey": null,
          "storageAccountName": "stroage1"
        },
        "name": "volume1"
      }
    ]
  },
  "resourceGroup": "demo",
  "type": "Microsoft.ServiceFabric/containerGroupSets"
}
```

