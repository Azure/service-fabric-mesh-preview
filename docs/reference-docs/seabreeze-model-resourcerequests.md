---
title: "ResourceRequests"
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
# ResourceRequests

The resource requests.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [memoryInGB](#memoryingb) | number (double) | Yes |
| [cpu](#cpu) | number (double) | Yes |

____
### memoryInGB
__Type__: number (double) <br/>
__Required__: Yes<br/>
<br/>
The memory request in GB of this container.

____
### cpu
__Type__: number (double) <br/>
__Required__: Yes<br/>
<br/>
The CPU request of this container.
