---
title: "VolumeMount"
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
# VolumeMount

The volume mount.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [name](#name) | string | Yes |
| [mountPath](#mountpath) | Object | Yes |
| [readOnly](#readonly) | boolean | No |

____
### name
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The volume name.

____
### mountPath
__Type__: Object <br/>
__Required__: Yes<br/>
<br/>
The path with in the container at which the volume should be mounted. Must not contain ':'. type: string

____
### readOnly
__Type__: boolean <br/>
__Required__: No<br/>
<br/>
The flag indicating whether the volume mount is read only.
