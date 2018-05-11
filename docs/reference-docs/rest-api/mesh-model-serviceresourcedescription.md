# ServiceResourceDescription

This type describes a service resource.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`id`](#id) | string | No |
| [`name`](#name) | string | No |
| [`type`](#type) | string | No |
| [`properties`](#properties) | [ServiceResourceProperties](mesh-model-serviceresourceproperties.md) | Yes |

____
### `id`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Fully qualified identifier for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}

____
### `name`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The name of the resource

____
### `type`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.

____
### `properties`
__Type__: [ServiceResourceProperties](mesh-model-serviceresourceproperties.md) <br/>
__Required__: Yes<br/>
<br/>
This type describes properties of a service resource.
