# Get
Gets the network resource.

Gets the information about the network resource with a given name. This information includes the network description and other runtime information.


## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/networks/{networkName}?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
| [`networkName`](#networkname) | string | Yes | Path |
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
### `networkName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the network.

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
| 200 (OK) | OK<br/> | [NetworkResourceDescription](mesh-model-networkresourcedescription.md) |
| All other status codes | Error<br/> | [ErrorModel](mesh-model-errormodel.md) |

## Examples

### NetworkGet

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/networks/helloWorldNetworkWindows?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
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
```

