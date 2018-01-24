---
title: "List"
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
# List
Lists all of the available ServiceFabric Resource Manager REST API operations.

Lists all the available ServiceFabric Resource Manager REST API operations.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/providers/Microsoft.ServiceFabric/operations?api-version={api-version}` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [api-version](#api-version) | string | Yes | Query |

____
### api-version
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The version of the ServiceFabric resouce provider api

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | OK. The request has succeeded.<br/> | [OperationListResult](seabreeze-model-operationlistresult.md) |
| All other status codes | Error response describing why the operation failed.<br/> | [ErrorModel](seabreeze-model-errormodel.md) |
