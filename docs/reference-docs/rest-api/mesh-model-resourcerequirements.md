# ResourceRequirements

This type describes the resource requirements for a container or a service.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`requests`](#requests) | [ResourceRequests](mesh-model-resourcerequests.md) | Yes |
| [`limits`](#limits) | [ResourceLimits](mesh-model-resourcelimits.md) | No |

____
### `requests`
__Type__: [ResourceRequests](mesh-model-resourcerequests.md) <br/>
__Required__: Yes<br/>
<br/>
Describes the requested resources for a given container.

____
### `limits`
__Type__: [ResourceLimits](mesh-model-resourcelimits.md) <br/>
__Required__: No<br/>
<br/>
Describes the maximum limits on the resources for a given container.
