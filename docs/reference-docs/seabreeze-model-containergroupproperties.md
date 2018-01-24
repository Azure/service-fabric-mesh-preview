---
title: "ContainerGroupProperties"
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
# ContainerGroupProperties

Describes the properties of a Container group.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [containers](#containers) | array of [Container](seabreeze-model-container.md) | Yes |
| [imageRegistryCredentials](#imageregistrycredentials) | array of [ImageRegistryCredential](seabreeze-model-imageregistrycredential.md) | No |
| [restartPolicy](#restartpolicy) | string (enum) | No |
| [ipAddress](#ipaddress) | [IpAddress](seabreeze-model-ipaddress.md) | No |
| [osType](#ostype) | string (enum) | Yes |
| [state](#state) | string | No |
| [volumes](#volumes) | array of [Volume](seabreeze-model-volume.md) | No |

____
### containers
__Type__: array of [Container](seabreeze-model-container.md) <br/>
__Required__: Yes<br/>
<br/>
The containers in this container group.

____
### imageRegistryCredentials
__Type__: array of [ImageRegistryCredential](seabreeze-model-imageregistrycredential.md) <br/>
__Required__: No<br/>
<br/>
The image registry credentials by which the container group is created from.

____
### restartPolicy
__Type__: string (enum) <br/>
__Required__: No<br/>
<br/>
- `always` Always restart





____
### ipAddress
__Type__: [IpAddress](seabreeze-model-ipaddress.md) <br/>
__Required__: No<br/>
<br/>
IP address for the container group.

____
### osType
__Type__: string (enum) <br/>
__Required__: Yes<br/>
<br/>
The base level OS type required by the containers in the group.




____
### state
__Type__: string <br/>
__Required__: No<br/>
<br/>
The state of the container group. Only valid in response.

____
### volumes
__Type__: array of [Volume](seabreeze-model-volume.md) <br/>
__Required__: No<br/>
<br/>
The volumes for this container group.
