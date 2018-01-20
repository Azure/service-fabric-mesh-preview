---
title: "ContainerInstanceView"
ms.date: "2018-01-20"
ms.prod: "azure"
ms.service: "SeaBreeze"
ms.topic: "reference"
applies_to: 
  - "Azure"
dev_langs: 
  - "rest-api"
helpviewer_keywords: 
  - "SeaBreeze Resource Provider API Reference"
---
# ContainerInstanceView

Information specific to a container instance.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [restartCount](#restartcount) | integer | No |
| [currentState](#currentstate) | [ContainerState](seabreeze-model-containerstate.md) | No |
| [previousState](#previousstate) | [ContainerState](seabreeze-model-containerstate.md) | No |
| [events](#events) | array of [ContainerEvent](seabreeze-model-containerevent.md) | No |

____
### restartCount
__Type__: integer <br/>
__Required__: No<br/>
<br/>
The number of times that the container has been restarted.

____
### currentState
__Type__: [ContainerState](seabreeze-model-containerstate.md) <br/>
__Required__: No<br/>
<br/>
Current container instance state..

____
### previousState
__Type__: [ContainerState](seabreeze-model-containerstate.md) <br/>
__Required__: No<br/>
<br/>
Previous container instance state..

____
### events
__Type__: array of [ContainerEvent](seabreeze-model-containerevent.md) <br/>
__Required__: No<br/>
<br/>
The events of this container instance.
