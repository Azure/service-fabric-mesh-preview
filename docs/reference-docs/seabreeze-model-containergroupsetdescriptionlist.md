---
title: "ContainerGroupSetDescriptionList"
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
# ContainerGroupSetDescriptionList

The container group set list response that contains the container group set properties.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [value](#value) | array of [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) | No |
| [nextLink](#nextlink) | string | No |

____
### value
__Type__: array of [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) <br/>
__Required__: No<br/>
<br/>
The list of container group sets.

____
### nextLink
__Type__: string <br/>
__Required__: No<br/>
<br/>
The URI to fetch the next page of container group sets.
