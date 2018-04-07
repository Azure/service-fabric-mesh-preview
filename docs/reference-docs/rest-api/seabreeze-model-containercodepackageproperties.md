# ContainerCodePackageProperties

Describes a container and its runtime properties.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`name`](#name) | string | Yes |
| [`image`](#image) | string | Yes |
| [`imageRegistryCredential`](#imageregistrycredential) | [ImageRegistryCredential](seabreeze-model-imageregistrycredential.md) | No |
| [`entrypoint`](#entrypoint) | string | No |
| [`commands`](#commands) | array of string | No |
| [`environmentVariables`](#environmentvariables) | array of [EnvironmentVariable](seabreeze-model-environmentvariable.md) | No |
| [`endpoints`](#endpoints) | array of [EndpointProperties](seabreeze-model-endpointproperties.md) | No |
| [`resources`](#resources) | [ResourceRequirements](seabreeze-model-resourcerequirements.md) | Yes |
| [`volumeRefs`](#volumerefs) | array of [ContainerVolume](seabreeze-model-containervolume.md) | No |
| [`instanceView`](#instanceview) | [ContainerInstanceView](seabreeze-model-containerinstanceview.md) | No |

____
### `name`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The name of the code package.

____
### `image`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The Container image to use.

____
### `imageRegistryCredential`
__Type__: [ImageRegistryCredential](seabreeze-model-imageregistrycredential.md) <br/>
__Required__: No<br/>
<br/>
Image registry credential.

____
### `entrypoint`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Override for the default entry point in the container.

____
### `commands`
__Type__: array of string <br/>
__Required__: No<br/>
<br/>
Command array to execute within the container in exec form.

____
### `environmentVariables`
__Type__: array of [EnvironmentVariable](seabreeze-model-environmentvariable.md) <br/>
__Required__: No<br/>
<br/>
The environment variables to set in this container

____
### `endpoints`
__Type__: array of [EndpointProperties](seabreeze-model-endpointproperties.md) <br/>
__Required__: No<br/>
<br/>
The endpoints exposed by this container.

____
### `resources`
__Type__: [ResourceRequirements](seabreeze-model-resourcerequirements.md) <br/>
__Required__: Yes<br/>
<br/>
This type describes the resource requirements for a container or a service.

____
### `volumeRefs`
__Type__: array of [ContainerVolume](seabreeze-model-containervolume.md) <br/>
__Required__: No<br/>
<br/>
The volumes to be attached to the container.

____
### `instanceView`
__Type__: [ContainerInstanceView](seabreeze-model-containerinstanceview.md) <br/>
__Required__: No<br/>
<br/>
Runtime information of a container instance.
