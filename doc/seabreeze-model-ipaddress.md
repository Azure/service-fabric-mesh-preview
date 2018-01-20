---
title: "IpAddress"
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
# IpAddress

IP address for the container group.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [ports](#ports) | array of [ContainerPort](seabreeze-model-containerport.md) | Yes |
| [type](#type) | string | Yes |
| [ip](#ip) | string | No |

____
### ports
__Type__: array of [ContainerPort](seabreeze-model-containerport.md) <br/>
__Required__: Yes<br/>
<br/>
The ports.

____
### type
__Type__: string <br/>
__Required__: Yes<br/>
__Default__: Public <br/>
<br/>
Determines whether the IP is exposed to the public internet.

____
### ip
__Type__: string <br/>
__Required__: No<br/>
<br/>
The IP exposed to the public internet.
