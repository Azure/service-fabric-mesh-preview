---
title: "ContainerEvent"
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
# ContainerEvent

A container event.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [count](#count) | integer | No |
| [firstTimestamp](#firsttimestamp) | string (date-time) | No |
| [lastTimestamp](#lasttimestamp) | string (date-time) | No |
| [message](#message) | string | No |
| [type](#type) | string | No |

____
### count
__Type__: integer <br/>
__Required__: No<br/>
<br/>
The count of the event.

____
### firstTimestamp
__Type__: string (date-time) <br/>
__Required__: No<br/>
<br/>
Date/time of the first event.

____
### lastTimestamp
__Type__: string (date-time) <br/>
__Required__: No<br/>
<br/>
Date/time of the last event.

____
### message
__Type__: string <br/>
__Required__: No<br/>
<br/>
The event message

____
### type
__Type__: string <br/>
__Required__: No<br/>
<br/>
The event type.
