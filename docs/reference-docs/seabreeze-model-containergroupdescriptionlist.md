---
title: "ContainerGroupDescriptionList"
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
# ContainerGroupDescriptionList

The container group instance list response that contains the container group properties.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [value](#value) | array of [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) | No |
| [nextLink](#nextlink) | string | No |

____
### value
__Type__: array of [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) <br/>
__Required__: No<br/>
<br/>
The list of container group instances.

____
### nextLink
__Type__: string <br/>
__Required__: No<br/>
<br/>
The URI to fetch the next page of container group instances.
