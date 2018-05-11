# Create
Creates or updates an application resource.

Creates an application resource with the specified name and description. If an application with the same name already exists, then its description is updated to the one indicated in this request.

Use network resources to provide public connectivity to the services of an application.


## Request
| Method | Request URI |
| ------ | ----------- |
| PUT | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/applications/{applicationName}?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
| [`applicationName`](#applicationname) | string | Yes | Path |
| [`api-version`](#api-version) | string | Yes | Query |
| [`applicationResourceDescription`](#applicationresourcedescription) | [ApplicationResourceDescription](seabreeze-model-applicationresourcedescription.md) | Yes | Body |

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

____
### `applicationResourceDescription`
__Type__: [ApplicationResourceDescription](seabreeze-model-applicationresourcedescription.md) <br/>
__Required__: Yes<br/>
<br/>
Description for creating an application resource.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | Ok<br/> | [ApplicationResourceDescription](seabreeze-model-applicationresourcedescription.md) |
| 201 (Created) | Created<br/> | [ApplicationResourceDescription](seabreeze-model-applicationresourcedescription.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### ApplicationCreateOrUpdate

#### Request
```
PUT https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/helloWorldApp?api-version=2018-03-01-privatepreview
```

##### Body
```json
{
  "properties": {
    "description": "SeaBreeze HelloWorld Application!",
    "services": [
      {
        "properties": {
          "osType": "linux",
          "codePackages": [
            {
              "name": "helloWorldCode",
              "image": "seabreeze/sbz-helloworld:1.0-alpine",
              "endpoints": [
                {
                  "name": "helloWorldListener",
                  "port": "80"
                }
              ],
              "resources": {
                "requests": {
                  "memoryInGB": "1",
                  "cpu": "1"
                }
              }
            }
          ],
          "description": "SeaBreeze Hello World Service.",
          "replicaCount": "1"
        },
        "name": "helloWorldService"
      }
    ]
  },
  "tags": {},
  "location": "EastUS"
}
```

#### 200 Response
##### Body
```json
{
  "type": "Microsoft.ServiceFabric/applications",
  "location": "EastUS",
  "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/myHelloWorldApp",
  "name": "myHelloWorldApp",
  "tags": {},
  "properties": {
    "provisioningState": "Updating",
    "description": "SeaBreeze HelloWorld Application!",
    "healthState": "Ok",
    "serviceNames": [
      "helloWorldService"
    ],
    "status": "Invalid"
  }
}
```

