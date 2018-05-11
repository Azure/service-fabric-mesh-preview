# List By Application Name
Gets services of a given application.

Gets the information about all services of a given service of an application. The information includes the runtime properties of the service instance.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/applications/{applicationName}/services?api-version=2018-03-01-privatepreview` |


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
| 200 (OK) | OK<br/> | [ServiceList](mesh-model-servicelist.md) |


## Examples

### ServiceGetAll

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/helloWorldApp/services?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "value": [
    {
      "name": "helloWorldService",
      "type": "Microsoft.ServiceFabric/services",
      "location": "eastus",
      "properties": {
        "osType": "Linux",
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
          },
          {
            "name": "helloWorldSideCar",
            "image": "seabreeze/sbz-helloworld-sidecar:1.0-alpine",
            "resources": {
              "requests": {
                "memoryInGB": "1",
                "cpu": "1"
              }
            }
          }
        ],
        "networkRefs": [
          {
            "name": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/networks/helloWorldNetwork"
          }
        ],
        "description": "Mesh Hello World Service.",
        "replicaCount": "1",
        "healthState": "Ok",
        "status": "Unknown"
      }
    }
  ]
}
```

