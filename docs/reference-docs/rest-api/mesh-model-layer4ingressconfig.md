# Layer4IngressConfig

Describes the layer4 configuration for public connectivity for this network.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`publicPort`](#publicport) | string | No |
| [`applicationName`](#applicationname) | string | No |
| [`serviceName`](#servicename) | string | No |
| [`endpointName`](#endpointname) | string | No |

____
### `publicPort`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Specifies the public port at which the service endpoint below needs to be exposed.

____
### `applicationName`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The application name which contains the service to be exposed.

____
### `serviceName`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The service whose endpoint needs to be exposed at the public port.

____
### `endpointName`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The service endpoint that needs to be exposed.
