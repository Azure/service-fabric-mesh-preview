# ApplicationResourceProperties

This type describes properties of an application resource.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`provisioningState`](#provisioningstate) | string | No |
| [`description`](#description) | string | No |
| [`debugParams`](#debugparams) | string | No |
| [`services`](#services) | array of [ServiceResourceDescription](seabreeze-model-serviceresourcedescription.md) | No |
| [`healthState`](#healthstate) | string (enum) | No |
| [`status`](#status) | string (enum) | No |
| [`serviceNames`](#servicenames) | array of string | No |
| [`diagnostics`](#diagnostics) | [DiagnosticsDescription](seabreeze-model-diagnosticsdescription.md) | No |

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
User readable description of the application.

____
### `debugParams`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Internal use.

____
### `services`
__Type__: array of [ServiceResourceDescription](seabreeze-model-serviceresourcedescription.md) <br/>
__Required__: No<br/>
<br/>
describes the services in the application.

____
### `healthState`
__Type__: string (enum) <br/>
__Required__: No<br/>
<br/>


The health state of a resource such as Application, Service, or Network.

Possible values are: 

  - `Invalid` - Indicates an invalid health state. All Service Fabric enumerations have the invalid type. The value is zero.
  - `Ok` - Indicates the health state is okay. The value is 1.
  - `Warning` - Indicates the health state is at a warning level. The value is 2.
  - `Error` - Indicates the health state is at an error level. Error health state should be investigated, as they can impact the correct functionality of the cluster. The value is 3.
  - `Unknown` - Indicates an unknown health status. The value is 65535.



____
### `status`
__Type__: string (enum) <br/>
__Required__: No<br/>
<br/>





____
### `serviceNames`
__Type__: array of string <br/>
__Required__: No<br/>
<br/>
Names of the services in the application.

____
### `diagnostics`
__Type__: [DiagnosticsDescription](seabreeze-model-diagnosticsdescription.md) <br/>
__Required__: No<br/>
<br/>
Describes the diagnostics definition and usage for an application resource.
