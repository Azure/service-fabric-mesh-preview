# IngressConfig

Describes public connectivity configuration for the network.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`qosLevel`](#qoslevel) | string (enum) | No |
| [`layer4`](#layer4) | array of [Layer4IngressConfig](seabreeze-model-layer4ingressconfig.md) | No |
| [`publicIPAddress`](#publicipaddress) | string | No |

____
### `qosLevel`
__Type__: string (enum) <br/>
__Required__: No<br/>
<br/>
The QoS tier for ingress.




____
### `layer4`
__Type__: array of [Layer4IngressConfig](seabreeze-model-layer4ingressconfig.md) <br/>
__Required__: No<br/>
<br/>
Configuration for layer4 public connectivity for this network.

____
### `publicIPAddress`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The public IP address for reaching this network.
