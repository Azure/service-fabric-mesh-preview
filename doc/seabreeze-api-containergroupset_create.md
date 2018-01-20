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
Creates or updates the container group set with the specified name and description.

Creates a container group set with the specified name and description. If a container group set with the same name already exists, then its description are updated to the one indicated in this request.

## Request
| Method | Request URI |
| ------ | ----------- |
| PUT | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroupSets/{containerGroupSetName}?api-version=2017-11-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [subscriptionId](#subscriptionid) | string | Yes | Path |
| [resourceGroupName](#resourcegroupname) | string | Yes | Path |
| [containerGroupSetName](#containergroupsetname) | string | Yes | Path |
| [api-version](#api-version) | string | Yes | Query |
| [containerGroupSet](#containergroupset) | [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) | Yes | Body |

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
### api-version
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: 2017-11-01-privatepreview <br/>
<br/>
The version of the API. This is a required parameter and it's value must be "2017-11-01-privatepreview".

____
### containerGroupSet
__Type__: [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) <br/>
__Required__: Yes<br/>
<br/>
The description of the container group set to be created or updated.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | Ok<br/> | [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) |
| 201 (Created) | Created<br/> | [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ContainerGroupSetCreateOrUpdate

#### Request
```
PUT https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resRg/providers/Microsoft.ServiceFabric/containerGroupSets/demo1?api-version=2017-11-01-privatepreview
```

##### Body
```json
{
  "containerGroups": {
    "properties": {
      "containers": [
        {
          "name": "FE",
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
    }
  },
  "instanceCount": "1"
}
```

#### 200 Response
##### Body
```json
{
  "id": "/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroupSets/demo1",
  "location": "WestUs",
  "name": "demo1",
  "provisioningState": "succeeded",
  "ContainerGroups": {
    "properties": {
      "containers": [
        {
          "name": "FE",
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
    }
  },
  "containerGroupInstanceNames": [
    "demo1_0"
  ],
  "instanceCount": "1",
  "resourceGroup": "demo",
  "type": "Microsoft.ServiceFabric/containerGroupSets"
}
```

