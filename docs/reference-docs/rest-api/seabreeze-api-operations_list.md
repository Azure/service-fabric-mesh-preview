# List
Lists all of the available operations.

Lists all the available operations provided by Service Fabric SeaBreeze resource provider.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/providers/Microsoft.ServiceFabric/operations?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`api-version`](#api-version) | string | Yes | Query |

____
### `api-version`
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: `2018-03-01-privatepreview` <br/>
<br/>
The version of the API. This parameter is required and its value must be `2018-03-01-privatepreview`.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | OK. The request has succeeded.<br/> | [OperationListResult](seabreeze-model-operationlistresult.md) |
| All other status codes | Error response describing why the operation failed.<br/> | [ErrorModel](seabreeze-model-errormodel.md) |
