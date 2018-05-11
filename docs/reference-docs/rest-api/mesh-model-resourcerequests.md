# ResourceRequests

This type describes the requested resources for a given container. It describes the least amount of resources required for the container. A container can consume more than requested resources up to the specified limits before being restarted. Currently, the requested resources are treated as limits.


## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`memoryInGB`](#memoryingb) | number (double) | Yes |
| [`cpu`](#cpu) | number (double) | Yes |

____
### `memoryInGB`
__Type__: number (double) <br/>
__Required__: Yes<br/>
<br/>
The memory request in GB for this container.

____
### `cpu`
__Type__: number (double) <br/>
__Required__: Yes<br/>
<br/>
Requested number of CPU cores. At present, only full cores are supported.
