# VolumeResourceDescription

This type describes a volume resource.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`id`](#id) | string | No |
| [`name`](#name) | string | No |
| [`type`](#type) | string | No |
| [`tags`](#tags) | map of string to string | No |
| [`location`](#location) | string | Yes |
| [`properties`](#properties) | [VolumeResourceProperties](mesh-model-volumeresourceproperties.md) | Yes |

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
### `tags`
__Type__: map of string to string <br/>
__Required__: No<br/>
<br/>
Resource tags.

____
### `location`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The geo-location where the resource lives

____
### `properties`
__Type__: [VolumeResourceProperties](mesh-model-volumeresourceproperties.md) <br/>
__Required__: Yes<br/>
<br/>
Describes properties of a volume resource.
