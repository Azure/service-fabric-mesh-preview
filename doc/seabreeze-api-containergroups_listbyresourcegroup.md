---
title: "Listby Resource Group"
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
# Listby Resource Group
Get a list of containers group in the specified resource group.

Get a list of containers and the properties of the container group in the specified resourceGroup.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroups?api-version=2017-11-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [subscriptionId](#subscriptionid) | string | Yes | Path |
| [api-version](#api-version) | string | Yes | Query |

____
### subscriptionId
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The customer subscription identifier

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
| 200 (OK) | OK<br/> | [ContainerGroupDescriptionList](seabreeze-model-containergroupdescriptionlist.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ContainerGroupInstancesList

#### Request
```
GET https://management.azure.com/subscriptions/subid/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroups?api-version=2017-11-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "value": [
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
      "tags": null,
      "type": "Microsoft.ServiceFabric/containerGroups"
    }
  ]
}
```

