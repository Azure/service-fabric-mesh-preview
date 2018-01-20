---
title: "ContainerGroupInstanceDescriptionList"
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
# ContainerGroupInstanceDescriptionList

The container group instance list response that contains the container group properties.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [value](#value) | array of [ContainerGroupInstanceDescription](seabreeze-model-containergroupinstancedescription.md) | No |
| [nextLink](#nextlink) | string | No |

____
### value
__Type__: array of [ContainerGroupInstanceDescription](seabreeze-model-containergroupinstancedescription.md) <br/>
__Required__: No<br/>
<br/>
The list of container group instances.

____
### nextLink
__Type__: string <br/>
__Required__: No<br/>
<br/>
The URI to fetch the next page of container group instances.
