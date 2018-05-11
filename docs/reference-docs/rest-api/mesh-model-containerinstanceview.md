# ContainerInstanceView

Runtime information of a container instance.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`restartCount`](#restartcount) | integer | No |
| [`currentState`](#currentstate) | [ContainerState](mesh-model-containerstate.md) | No |
| [`previousState`](#previousstate) | [ContainerState](mesh-model-containerstate.md) | No |
| [`events`](#events) | array of [ContainerEvent](mesh-model-containerevent.md) | No |

____
### `restartCount`
__Type__: integer <br/>
__Required__: No<br/>
<br/>
The number of times the container has been restarted.

____
### `currentState`
__Type__: [ContainerState](mesh-model-containerstate.md) <br/>
__Required__: No<br/>
<br/>
Current container instance state.

____
### `previousState`
__Type__: [ContainerState](mesh-model-containerstate.md) <br/>
__Required__: No<br/>
<br/>
Previous container instance state.

____
### `events`
__Type__: array of [ContainerEvent](mesh-model-containerevent.md) <br/>
__Required__: No<br/>
<br/>
The events of this container instance.