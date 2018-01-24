---
title: "OperationResult"
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
# OperationResult

Available operation list result

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [name](#name) | string | No |
| [display](#display) | [AvailableOperationDisplay](seabreeze-model-availableoperationdisplay.md) | No |
| [origin](#origin) | string | No |
| [nextLink](#nextlink) | string | No |

____
### name
__Type__: string <br/>
__Required__: No<br/>
<br/>
The name of the operation.

____
### display
__Type__: [AvailableOperationDisplay](seabreeze-model-availableoperationdisplay.md) <br/>
__Required__: No<br/>
<br/>
The object that represents the operation.

____
### origin
__Type__: string <br/>
__Required__: No<br/>
<br/>
Origin result

____
### nextLink
__Type__: string <br/>
__Required__: No<br/>
<br/>
The URL to use for getting the next set of results.
