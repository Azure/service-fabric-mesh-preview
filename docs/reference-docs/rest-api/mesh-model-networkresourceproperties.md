# NetworkResourceProperties

Describes properties of a network resource.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`provisioningState`](#provisioningstate) | string | No |
| [`description`](#description) | string | No |
| [`addressPrefix`](#addressprefix) | string | Yes |
| [`ingressConfig`](#ingressconfig) | [IngressConfig](mesh-model-ingressconfig.md) | No |

____
### `provisioningState`
__Type__: string <br/>
__Required__: No<br/>
<br/>
State of the resource.

____
### `description`
__Type__: string <br/>
__Required__: No<br/>
<br/>
User readable description of the network.

____
### `addressPrefix`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
the address prefix for this network.

____
### `ingressConfig`
__Type__: [IngressConfig](mesh-model-ingressconfig.md) <br/>
__Required__: No<br/>
<br/>
Configuration for public connectivity for this network.
