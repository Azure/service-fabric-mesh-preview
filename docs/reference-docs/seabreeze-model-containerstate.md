---
title: "ContainerState"
ms.date: "2018-01-23"
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
# ContainerState

The container state.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [state](#state) | string | No |
| [startTime](#starttime) | string (date-time) | No |
| [exitCode](#exitcode) | integer | No |
| [finishTime](#finishtime) | string (date-time) | No |
| [detailStatus](#detailstatus) | string | No |

____
### state
__Type__: string <br/>
__Required__: No<br/>
<br/>
The state of this container

____
### startTime
__Type__: string (date-time) <br/>
__Required__: No<br/>
<br/>
Date/time when the container state started.

____
### exitCode
__Type__: integer <br/>
__Required__: No<br/>
<br/>
The container exit code.

____
### finishTime
__Type__: string (date-time) <br/>
__Required__: No<br/>
<br/>
Date/time when the container state finished.

____
### detailStatus
__Type__: string <br/>
__Required__: No<br/>
<br/>
Human-readable status of this state.
