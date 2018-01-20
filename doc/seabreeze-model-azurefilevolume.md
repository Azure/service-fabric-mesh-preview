---
title: "AzureFileVolume"
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
# AzureFileVolume

The Azure file volume.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [shareName](#sharename) | string | Yes |
| [readOnly](#readonly) | boolean | No |
| [storageAccountName](#storageaccountname) | string | Yes |
| [storageAccountKey](#storageaccountkey) | string | No |

____
### shareName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The Azure file share name.

____
### readOnly
__Type__: boolean <br/>
__Required__: No<br/>
<br/>
The flag indicating whether the Azure file volume is read only.

____
### storageAccountName
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The storage account name to access to the Azure file.

____
### storageAccountKey
__Type__: string <br/>
__Required__: No<br/>
<br/>
The storage account key to access to the Azure file.
