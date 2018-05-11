# List By Resource Group
Gets all the network resources in a given resource group.

Gets the information about all network resources in a given resource group. The information includes the network description and other runtime properties.


## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/networks?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
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
### `api-version`
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: `2018-03-01-privatepreview` <br/>
<br/>
The version of the API. This parameter is required and its value must be `2018-03-01-privatepreview`.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | OK<br/> | [NetworkResourceDescriptionList](seabreeze-model-networkresourcedescriptionlist.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### NetworksList

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/networks?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "value": [
    {
      "type": "Microsoft.ServiceFabric/networks",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/networks/helloWorldNetwork",
      "name": "helloWorldNetwork",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "addressPrefix": "10.0.0.4/22",
        "ingressConfig": {
          "qosLevel": "Bronze",
          "publicIPAddress": "52.191.12.219",
          "layer4": [
            {
              "publicPort": "80",
              "applicationName": "helloWorldApp",
              "serviceName": "helloWorldService",
              "endpointName": "helloWorldListener"
            }
          ]
        }
      }
    },
    {
      "type": "Microsoft.ServiceFabric/networks",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/networks/helloWorldNetworkWindows",
      "name": "helloWorldNetworkWindows",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "addressPrefix": "10.0.0.4/22",
        "ingressConfig": {
          "qosLevel": "Bronze",
          "publicIPAddress": "52.191.255.103",
          "layer4": [
            {
              "publicPort": "80",
              "applicationName": "helloWorldAppWindows",
              "serviceName": "helloWorldService",
              "endpointName": "helloWorldListener"
            }
          ]
        }
      }
    }
  ]
}
```

