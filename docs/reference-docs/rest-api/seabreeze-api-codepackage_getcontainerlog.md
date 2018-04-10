# Get Container Log
Gets the logs for the container.

Get the logs for the container of a given code package of an application.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/applications/{applicationName}/services/{serviceName}/replicas/{replicaName}/codePackages/{codePackageName}/logs?api-version=2018-03-01-privatepreview&tail={tail}` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
| [`applicationName`](#applicationname) | string | Yes | Path |
| [`serviceName`](#servicename) | string | Yes | Path |
| [`replicaName`](#replicaname) | string | Yes | Path |
| [`codePackageName`](#codepackagename) | string | Yes | Path |
| [`api-version`](#api-version) | string | Yes | Query |
| [`tail`](#tail) | integer | No | Query |

____
### `subscriptionId`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The customer subscription identifier

____
### `resourceGroupName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Azure resource group name

____
### `applicationName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the application.

____
### `serviceName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the service.

____
### `replicaName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the service replica.

____
### `codePackageName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Code package name

____
### `api-version`
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: `2018-03-01-privatepreview` <br/>
<br/>
The version of the API. This parameter is required and its value must be `2018-03-01-privatepreview`.

____
### `tail`
__Type__: integer <br/>
__Required__: No<br/>
<br/>
Only show this number of log lines. If not provided, the last 100 lines are shown.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | Successful response<br/> | [ContainerLogs](seabreeze-model-containerlogs.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ContainerLogsList

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/sbzDocApp/services/sbzDocService/replicas/0/codePackages/sbzDocCode/logs?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
The response body is empty.