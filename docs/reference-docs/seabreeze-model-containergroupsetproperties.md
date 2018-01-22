---
title: "ContainerGroupSetProperties"
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
# ContainerGroupSetProperties

Container group set properties.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [provisioningState](#provisioningstate) | string | No |
| [containerGroup](#containergroup) | [ContainerGroupProperties](seabreeze-model-containergroupproperties.md) | No |
| [instanceNames](#instancenames) | array of string | No |
| [instanceCount](#instancecount) | integer | No |

____
### provisioningState
__Type__: string <br/>
__Required__: No<br/>
<br/>
The provisioning state, which only appears in the response.

____
### containerGroup
__Type__: [ContainerGroupProperties](seabreeze-model-containergroupproperties.md) <br/>
__Required__: No<br/>
<br/>
The properties of the container groups in this container group set.

____
### instanceNames
__Type__: array of string <br/>
__Required__: No<br/>
<br/>
The names of the container group instances.

____
### instanceCount
__Type__: integer <br/>
__Required__: No<br/>
<br/>
The number of container group instances to create. Defaults to 1 if this parameter is not specified.
