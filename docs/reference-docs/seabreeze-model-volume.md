---
title: "Volume"
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
# Volume

The volume definition for the container group.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [name](#name) | string | Yes |
| [azureFile](#azurefile) | [AzureFileVolume](seabreeze-model-azurefilevolume.md) | Yes |

____
### name
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The volume name.

____
### azureFile
__Type__: [AzureFileVolume](seabreeze-model-azurefilevolume.md) <br/>
__Required__: Yes<br/>
<br/>
The Azure file volume.
