# ServiceReplicaDescription

This type describes a replica of a service resource.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`osType`](#ostype) | string (enum) | Yes |
| [`codePackages`](#codepackages) | array of [ContainerCodePackageProperties](seabreeze-model-containercodepackageproperties.md) | Yes |
| [`networkRefs`](#networkrefs) | array of [NetworkRef](seabreeze-model-networkref.md) | No |
| [`replicaName`](#replicaname) | string | No |

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
### `replicaName`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Name of the replica.
