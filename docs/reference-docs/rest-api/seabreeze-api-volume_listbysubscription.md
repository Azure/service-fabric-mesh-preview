# List By Subscription
Gets all the volume resources in a given subscription.

Gets the information about all volume resources in a given subscription. The information includes the volume description and other runtime information.


## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/volumes?api-version=2018-03-01-privatepreview` |


## Parameters
| Name | Type | Required | Location |
| --- | --- | --- | --- |
| [`subscriptionId`](#subscriptionid) | string | Yes | Path |
| [`api-version`](#api-version) | string | Yes | Query |

____
### `subscriptionId`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The customer subscription identifier

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
| 200 (OK) | OK<br/> | [VolumeResourceDescriptionList](seabreeze-model-volumeresourcedescriptionlist.md) |
| All other status codes | Error<br/> | [ErrorModel](seabreeze-model-errormodel.md) |

## Examples

### VolumesList

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.ServiceFabric/volumes?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "value": [
    {
      "type": "Microsoft.ServiceFabric/volumes",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbzdemo/providers/Microsoft.ServiceFabric/volumes/mysharel",
      "name": "mysharel",
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
    },
    {
      "type": "Microsoft.ServiceFabric/volumes",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbzdemo/providers/Microsoft.ServiceFabric/volumes/mysharew",
      "name": "mysharew",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "description": "File share backed by Azure Files storage.",
        "provider": "SFAzureFile",
        "azureFileParameters": {
          "shareName": "sharew",
          "accountName": "sbzdemoaccount"
        }
      }
    }
  ]
}
```

