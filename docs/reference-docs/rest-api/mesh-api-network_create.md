# Create
Creates or updates a network resource.

Creates a network resource with the specified name and description. If a network with the same name already exists, then its description is updated to the one indicated in this request.

Use network resources to create private network and configure public connectivity for services within your application. 


## Request
| Method | Request URI |
| ------ | ----------- |
| PUT | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/networks/{networkName}?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
| [`networkName`](#networkname) | string | Yes | Path |
| [`api-version`](#api-version) | string | Yes | Query |
| [`networkResourceDescription`](#networkresourcedescription) | [NetworkResourceDescription](seabreeze-model-networkresourcedescription.md) | Yes | Body |

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

____
### `networkResourceDescription`
__Type__: [NetworkResourceDescription](seabreeze-model-networkresourcedescription.md) <br/>
__Required__: Yes<br/>
<br/>
Description for creating a network resource.

## Responses

| HTTP Status Code | Description | Response Schema |
| --- | --- | --- |
| 200 (OK) | Ok<br/> | [NetworkResourceDescription](seabreeze-model-networkresourcedescription.md) |
| 201 (Created) | Created<br/> | [NetworkResourceDescription](seabreeze-model-networkresourcedescription.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### Network_Create

This example shows how to create a network resource with custom address range and a load balanced public endpoint.

#### Request
```
PUT https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/networks/helloWorldNetworkWindows?api-version=2018-03-01-privatepreview
```

##### Body
```json
{
  "properties": {
    "addressPrefix": "10.0.0.4/22",
    "ingressConfig": {
      "layer4": [
        {
          "publicPort": "80",
          "applicationName": "helloWorldAppWindows",
          "serviceName": "helloWorldService",
          "endpointName": "helloWorldListener"
        }
      ]
    }
  },
  "location": "eastus"
}
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
    "provisioningState": "Updating",
    "addressPrefix": "10.0.0.4/22",
    "ingressConfig": {
      "qosLevel": "Bronze",
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

