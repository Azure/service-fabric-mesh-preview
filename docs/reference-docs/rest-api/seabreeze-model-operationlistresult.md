# OperationListResult

Describes the result of the request to list Service Fabric operations.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`value`](#value) | array of [OperationResult](seabreeze-model-operationresult.md) | No |
| [`nextLink`](#nextlink) | string | No |

____
### `value`
__Type__: array of [OperationResult](seabreeze-model-operationresult.md) <br/>
__Required__: No<br/>
<br/>
List of Service Fabric operations supported by the Microsoft.ServiceFabric resource provider.

____
### `nextLink`
__Type__: string <br/>
__Required__: No<br/>
<br/>
URL to get the next set of operation list results if there are any.
