# ContainerVolume

Describes how a volume is attached to a container.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`name`](#name) | string | Yes |
| [`readOnly`](#readonly) | boolean | No |
| [`destinationPath`](#destinationpath) | string | Yes |

____
### `name`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Name of the volume.

____
### `readOnly`
__Type__: boolean <br/>
__Required__: No<br/>
<br/>
The flag indicating whether the volume is read only. Default is 'false'.

____
### `destinationPath`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The path within the container at which the volume should be mounted. Only valid path characters are allowed.
