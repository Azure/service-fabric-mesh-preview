---
title: "Get"
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
# Get


Get the logs for this container.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroups/{containerGroupName}/containers/{containerName}/logs?api-version=2017-11-01-privatepreview&tail={tail}` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [subscriptionId](#subscriptionid) | string | Yes | Path |
| [resourceGroupName](#resourcegroupname) | string | Yes | Path |
| [containerGroupName](#containergroupname) | string | Yes | Path |
| [containerName](#containername) | string | Yes | Path |
| [api-version](#api-version) | string | Yes | Query |
| [tail](#tail) | integer | No | Query |

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
### containerName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Container name

____
### api-version
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: 2017-11-01-privatepreview <br/>
<br/>
The version of the API. This is a required parameter and it's value must be "2017-11-01-privatepreview".

____
### tail
__Type__: integer <br/>
__Required__: No<br/>
<br/>
Only show this number of log lines. If not provided, all available logs are shown.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | Successful response<br/> | [ContainerLogs](seabreeze-model-containerlogs.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ContainerGroupContainerLogsList

#### Request
```
GET https://management.azure.com/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroups/demo1/containers/container1/logs?api-version=2017-11-01-privatepreview&tail=10
```

#### 200 Response
##### Body
```json
{
  "content": "log content"
}
```

