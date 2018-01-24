---
title: "ContainerGroupDescription"
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
# ContainerGroupDescription

Describes a Container group.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [id](#id) | string | No |
| [name](#name) | string | No |
| [type](#type) | string | No |
| [location](#location) | string | Yes |
| [tags](#tags) | map of string to string | No |
| [properties](#properties) | [ContainerGroupProperties](seabreeze-model-containergroupproperties.md) | Yes |

____
### id
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure resource ID.

____
### name
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure resource name.

____
### type
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure resource type.

____
### location
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Resource location.

____
### tags
__Type__: map of string to string <br/>
__Required__: No<br/>
<br/>
Resource tags.

____
### properties
__Type__: [ContainerGroupProperties](seabreeze-model-containergroupproperties.md) <br/>
__Required__: Yes<br/>
<br/>
Describes the properties of a Container group.
