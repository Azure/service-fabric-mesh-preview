# Get
Gets the application resource.

Gets the information about the application resource with a given name. The information includes the information about the application's services and other runtime properties.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/applications/{applicationName}?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
| [`applicationName`](#applicationname) | string | Yes | Path |
| [`api-version`](#api-version) | string | Yes | Query |

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
### `api-version`
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: `2018-03-01-privatepreview` <br/>
<br/>
The version of the API. This parameter is required and its value must be `2018-03-01-privatepreview`.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | OK<br/> | [ApplicationResourceDescription](mesh-model-applicationresourcedescription.md) |
| All other status codes | Error<br/> | [ErrorModel](mesh-model-errormodel.md) |

## Examples

### ApplicationGet

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/demo1?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "type": "Microsoft.ServiceFabric/applications",
  "location": "eastus",
  "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/helloWorldAppWindows",
  "name": "helloWorldAppWindows",
  "tags": {},
  "properties": {
    "provisioningState": "Succeeded",
    "description": "Mesh HelloWorld Application!",
    "healthState": "Ok",
    "serviceNames": [
      "helloWorldService"
    ],
    "status": "Ready"
  }
}
```

