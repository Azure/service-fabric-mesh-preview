---
title: "Delete"
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
# Delete
Deletes the specified container group.

Deletes the container group identified by the name.

## Request
| Method | Request URI |
| ------ | ----------- |
| DELETE | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/containerGroups/{containerGroupName}?api-version=2017-11-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [subscriptionId](#subscriptionid) | string | Yes | Path |
| [resourceGroupName](#resourcegroupname) | string | Yes | Path |
| [containerGroupName](#containergroupname) | string | Yes | Path |
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

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | OK<br/> |  |
| 204 (NoContent) | No Content - the specified container group was not found.<br/> |  |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ContainerGroupsDelete

#### Request
```
DELETE https://management.azure.com/subscriptions/subid/resourceGroups/demo/providers/Microsoft.ServiceFabric/containerGroups/demo1?api-version=2017-11-01-privatepreview
```

#### 200 Response
##### Body
The response body is empty.