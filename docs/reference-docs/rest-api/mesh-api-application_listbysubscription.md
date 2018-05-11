# List By Subscription
Gets all the application resources in a given subscription.

Gets the information about all application resources in a given subscription. The information includes the information about the application's services and other runtime properties.

## Request
| Method | Request URI |
| ------ | ----------- |
| GET | `/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/applications?api-version=2018-03-01-privatepreview` |


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
| 200 (OK) | OK<br/> | [ApplicationResourceDescriptionList](mesh-model-applicationresourcedescriptionlist.md) |
| All other status codes | Error<br/> | [ErrorModel](mesh-model-errormodel.md) |

## Examples

### ApplicationList

#### Request
```
GET https://management.azure.com/subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.ServiceFabric/applications?api-version=2018-03-01-privatepreview
```

#### 200 Response
##### Body
```json
{
  "value": [
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/abhisramvol/providers/Microsoft.ServiceFabric/applications/myappl",
      "name": "myappl",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "healthState": "Ok",
        "serviceNames": [
          "myservice"
        ],
        "status": "Ready"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/abhisramvol/providers/Microsoft.ServiceFabric/applications/myappw",
      "name": "myappw",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "healthState": "Ok",
        "serviceNames": [
          "myservice"
        ],
        "status": "Ready"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "EastUS",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/mfussellapp2/providers/Microsoft.ServiceFabric/applications/SbzVoting",
      "name": "SbzVoting",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "description": "Voting Mesh!",
        "healthState": "Ok",
        "serviceNames": [
          "VotingWeb",
          "VotingData"
        ],
        "status": "Ready"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "EastUS",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/mfussellapp3/providers/Microsoft.ServiceFabric/applications/SbzVoting",
      "name": "SbzVoting",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "description": "Voting Mesh!",
        "healthState": "Ok",
        "serviceNames": [
          "VotingWeb",
          "VotingData"
        ],
        "status": "Ready"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sbz_demo/providers/Microsoft.ServiceFabric/applications/helloWorldApp",
      "name": "helloWorldApp",
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
    },
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
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sridhar1ResourceGroup/providers/Microsoft.ServiceFabric/applications/privateRegistryExampleApp",
      "name": "privateRegistryExampleApp",
      "tags": {},
      "properties": {
        "provisioningState": "Updating",
        "description": "Mesh example application with container deployed from private image registry.",
        "healthState": "Ok",
        "serviceNames": [
          "helloWorldService"
        ],
        "status": "Invalid"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sridhar4ResourceGroup/providers/Microsoft.ServiceFabric/applications/SbzVoting",
      "name": "SbzVoting",
      "tags": {},
      "properties": {
        "provisioningState": "Succeeded",
        "description": "Voting Mesh!",
        "healthState": "Ok",
        "serviceNames": [
          "VotingWeb",
          "VotingData"
        ],
        "status": "Ready"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sridharResourceGroup/providers/Microsoft.ServiceFabric/applications/privateRegistryExampleApp",
      "name": "privateRegistryExampleApp",
      "tags": {},
      "properties": {
        "provisioningState": "Updating",
        "description": "Mesh example application with container deployed from private image registry.",
        "healthState": "Ok",
        "serviceNames": [
          "helloWorldService"
        ],
        "status": "Invalid"
      }
    },
    {
      "type": "Microsoft.ServiceFabric/applications",
      "location": "eastus",
      "id": "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/sridharRG/providers/Microsoft.ServiceFabric/applications/privateRegistryExampleApp",
      "name": "privateRegistryExampleApp",
      "tags": {},
      "properties": {
        "provisioningState": "Updating",
        "description": "Mesh example application with container deployed from private image registry.",
        "healthState": "Ok",
        "serviceNames": [
          "helloWorldService"
        ],
        "status": "Invalid"
      }
    }
  ]
}
```

