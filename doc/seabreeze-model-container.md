---
title: "Container"
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
# Container

A container instance.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [name](#name) | string | Yes |
| [properties](#properties) | [ContainerProperties](seabreeze-model-containerproperties.md) | Yes |

____
### name
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The user-provided name of this container

____
### properties
__Type__: [ContainerProperties](seabreeze-model-containerproperties.md) <br/>
__Required__: Yes<br/>
<br/>
The container properties.
