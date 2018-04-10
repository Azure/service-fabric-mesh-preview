# ServiceResourceProperties

This type describes properties of a service resource.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`osType`](#ostype) | string (enum) | Yes |
| [`codePackages`](#codepackages) | array of [ContainerCodePackageProperties](seabreeze-model-containercodepackageproperties.md) | Yes |
| [`networkRefs`](#networkrefs) | array of [NetworkRef](seabreeze-model-networkref.md) | No |
| [`description`](#description) | string | No |
| [`replicaCount`](#replicacount) | integer | No |
| [`healthState`](#healthstate) | string (enum) | No |
| [`status`](#status) | string (enum) | No |

____
### `osType`
__Type__: string (enum) <br/>
__Required__: Yes<br/>
<br/>
The Operating system type required by the code in service.





____
### `codePackages`
__Type__: array of [ContainerCodePackageProperties](seabreeze-model-containercodepackageproperties.md) <br/>
__Required__: Yes<br/>
<br/>
Describes the set of code packages that forms the service. A code package describes the container and the properties for running it. All the code packages are started together on the same host and share the same context (network, process etc.).


____
### `networkRefs`
__Type__: array of [NetworkRef](seabreeze-model-networkref.md) <br/>
__Required__: No<br/>
<br/>
The names of the private networks that this service needs to be part of.

____
### `description`
__Type__: string <br/>
__Required__: No<br/>
<br/>
User readable description of the service.

____
### `replicaCount`
__Type__: integer <br/>
__Required__: No<br/>
<br/>
The number of replicas of the service to create. Defaults to 1 if not specified.

____
### `healthState`
__Type__: string (enum) <br/>
__Required__: No<br/>
<br/>
Describes the health state of an services resource.

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




