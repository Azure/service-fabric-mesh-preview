# NetworkProperties

Describes a network.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`description`](#description) | string | No |
| [`addressPrefix`](#addressprefix) | string | Yes |
| [`ingressConfig`](#ingressconfig) | [IngressConfig](seabreeze-model-ingressconfig.md) | No |

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
__Type__: [IngressConfig](seabreeze-model-ingressconfig.md) <br/>
__Required__: No<br/>
<br/>
Configuration for public connectivity for this network.
