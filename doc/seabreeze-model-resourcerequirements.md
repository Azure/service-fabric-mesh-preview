---
title: "ResourceRequirements"
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
# ResourceRequirements

The resource requirements.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [requests](#requests) | [ResourceRequests](seabreeze-model-resourcerequests.md) | Yes |
| [limits](#limits) | [ResourceLimits](seabreeze-model-resourcelimits.md) | No |

____
### requests
__Type__: [ResourceRequests](seabreeze-model-resourcerequests.md) <br/>
__Required__: Yes<br/>
<br/>
The resource requests of this container.

____
### limits
__Type__: [ResourceLimits](seabreeze-model-resourcelimits.md) <br/>
__Required__: No<br/>
<br/>
The resource limits of this container.
