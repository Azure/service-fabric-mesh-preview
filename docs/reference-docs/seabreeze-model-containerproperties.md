---
title: "ContainerProperties"
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
# ContainerProperties

The container properties.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [image](#image) | string | Yes |
| [command](#command) | array of string | No |
| [ports](#ports) | array of [ContainerPort](seabreeze-model-containerport.md) | No |
| [environmentVariables](#environmentvariables) | array of [EnvironmentVariable](seabreeze-model-environmentvariable.md) | No |
| [instanceView](#instanceview) | [ContainerInstanceView](seabreeze-model-containerinstanceview.md) | No |
| [resources](#resources) | [ResourceRequirements](seabreeze-model-resourcerequirements.md) | Yes |
| [volumeMounts](#volumemounts) | array of [VolumeMount](seabreeze-model-volumemount.md) | No |

____
### image
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The name of the image used when creating this container

____
### command
__Type__: array of string <br/>
__Required__: No<br/>
<br/>
Command array to execute within the container in exec form.

____
### ports
__Type__: array of [ContainerPort](seabreeze-model-containerport.md) <br/>
__Required__: No<br/>
<br/>
The ports exposed by this container

____
### environmentVariables
__Type__: array of [EnvironmentVariable](seabreeze-model-environmentvariable.md) <br/>
__Required__: No<br/>
<br/>
The environment variables to set in this container

____
### instanceView
__Type__: [ContainerInstanceView](seabreeze-model-containerinstanceview.md) <br/>
__Required__: No<br/>
<br/>
Information specific to a container instance.

____
### resources
__Type__: [ResourceRequirements](seabreeze-model-resourcerequirements.md) <br/>
__Required__: Yes<br/>
<br/>
The resource requirements.

____
### volumeMounts
__Type__: array of [VolumeMount](seabreeze-model-volumemount.md) <br/>
__Required__: No<br/>
<br/>
The volume mounts.
