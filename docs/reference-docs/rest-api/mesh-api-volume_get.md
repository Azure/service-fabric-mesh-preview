# Get
Gets the volume resource.

Gets the information about the volume resource with a given name. This information includes the volume description and other runtime information.


## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/volumes/{volumeName}?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`resourceGroupName`](#resourcegroupname) | string | Yes | Path |
| [`volumeName`](#volumename) | string | Yes | Path |
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
### `volumeName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The identity of the volume.

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
| 200 (OK) | OK<br/> | [VolumeResourceDescription](mesh-model-volumeresourcedescription.md) |
| All other status codes | Error<br/> | [ErrorModel](mesh-model-errormodel.md) |

## Examples

### VolumeGet

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sbz_demo/providers/Microsoft.ServiceFabric/volumes/sbzDemoVolume?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "type": "Microsoft.ServiceFabric/volumes",
  "location": "eastus",
  "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/volumes/sbzDemoVolume",
  "name": "sbzDemoVolume",
  "tags": {},
  "properties": {
    "provisioningState": "Succeeded",
    "description": "File share backed by Azure Files storage.",
    "provider": "SFAzureFile",
    "azureFileParameters": {
      "shareName": "sharel",
      "accountName": "sbzdemoaccount"
    }
  }
}
```
