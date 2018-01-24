---
title: "SeaBreeze Resource Provider API Reference"
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


# SeaBreeze Container Group Sets REST API Reference




----
## [ContainerGroupSetInstance APIs](seabreeze-index-containergroupsetinstance.md)

| Name | Description |
| --- | --- |
| [Get](seabreeze-api-containergroupsetinstance_get.md) | Gets the properties of the specified container group.<br/> |
| [List](seabreeze-api-containergroupsetinstance_list.md) | Gets the properties of all container groups in the container group set.<br/> |

----
## [ContainerGroupSet APIs](seabreeze-index-containergroupset.md)

| Name | Description |
| --- | --- |
| [List By Subscription Id](seabreeze-api-containergroupsets_listbysubscriptionid.md) | Gets all the container groups sets in the given subscription.<br/> |
| [List By Resource Group](seabreeze-api-containergroupsets_listbyresourcegroup.md) | Gets all the container groups sets in the given resource group.<br/> |
| [Create](seabreeze-api-containergroupset_create.md) | Creates or updates the container group set with the specified name and description.<br/> |
| [Get](seabreeze-api-containergroupset_get.md) | Gets the container groups in the given container group set.<br/> |
| [Delete](seabreeze-api-containergroupset_delete.md) | Deletes the specified container group set.<br/> |

----
## [ContainerGroupSetContainerLogs APIs](seabreeze-index-containergroupsetcontainerlogs.md)

| Name | Description |
| --- | --- |
| [Get](seabreeze-api-containergroupsetcontainerlogs_get.md) | Gets the logs for a specific container.<br/> |

----
## [ContainerGroups APIs](seabreeze-index-containergroups.md)

| Name | Description |
| --- | --- |
| [Create](seabreeze-api-containergroups_create.md) | Creates or updates the container group with the specified name and description.<br/> |
| [Get](seabreeze-api-containergroups_get.md) | Gets the container group with the given name.<br/> |
| [Delete](seabreeze-api-containergroups_delete.md) | Deletes the specified container group.<br/> |
| [Listby Resource Group](seabreeze-api-containergroups_listbyresourcegroup.md) | Get a list of containers group in the specified resource group.<br/> |
| [List By Subscription](seabreeze-api-containergroups_listbysubscription.md) | Get a list of containers group in the specified subscription.<br/> |

----
## [ContainerGroupContainerLogs APIs](seabreeze-index-containergroupcontainerlogs.md)

| Name | Description |
| --- | --- |
| [Get](seabreeze-api-containergroupscontainerlogs_get.md) | Gets the logs for a specific container.<br/> |

----
## [Operations APIs](seabreeze-index-operations.md)

| Name | Description |
| --- | --- |
| [List](seabreeze-api-operations_list.md) | Lists all of the available ServiceFabric Resource Manager REST API operations.<br/> |

----
## [Models](seabreeze-index-models.md)

| Name | Description |
| --- | --- |
| [AvailableOperationDisplay](seabreeze-model-availableoperationdisplay.md) | Operation supported by Service Fabric resource provider<br/> |
| [AzureFileVolume](seabreeze-model-azurefilevolume.md) | The Azure file volume.<br/> |
| [Container](seabreeze-model-container.md) | A container instance.<br/> |
| [ContainerEvent](seabreeze-model-containerevent.md) | A container event.<br/> |
| [ContainerGroupDescription](seabreeze-model-containergroupdescription.md) | Describes a Container group.<br/> |
| [ContainerGroupDescriptionList](seabreeze-model-containergroupdescriptionlist.md) | The container group instance list response that contains the container group properties.<br/> |
| [ContainerGroupInstanceDescription](seabreeze-model-containergroupinstancedescription.md) | Describes a Container group instance.<br/> |
| [ContainerGroupInstanceDescriptionList](seabreeze-model-containergroupinstancedescriptionlist.md) | The container group instance list response that contains the container group properties.<br/> |
| [ContainerGroupProperties](seabreeze-model-containergroupproperties.md) | Describes the properties of a Container group.<br/> |
| [ContainerGroupSetDescription](seabreeze-model-containergroupsetdescription.md) | Describes a Container group set.<br/> |
| [ContainerGroupSetDescriptionList](seabreeze-model-containergroupsetdescriptionlist.md) | The container group set list response that contains the container group set properties.<br/> |
| [ContainerGroupSetProperties](seabreeze-model-containergroupsetproperties.md) | Container group set properties.<br/> |
| [ContainerInstanceView](seabreeze-model-containerinstanceview.md) | Information specific to a container instance.<br/> |
| [ContainerLogs](seabreeze-model-containerlogs.md) | The logs of the container.<br/> |
| [ContainerPort](seabreeze-model-containerport.md) | The container port.<br/> |
| [ContainerProperties](seabreeze-model-containerproperties.md) | The container properties.<br/> |
| [ContainerRestartPolicy enum](seabreeze-model-containerrestartpolicy.md) | Possible values include: 'always'<br/> |
| [ContainerState](seabreeze-model-containerstate.md) | The container state.<br/> |
| [EnvironmentVariable](seabreeze-model-environmentvariable.md) | Environment variable to set within the container.<br/> |
| [ErrorModel](seabreeze-model-errormodel.md) | The error details.<br/> |
| [ImageRegistryCredential](seabreeze-model-imageregistrycredential.md) | Image registry credential.<br/> |
| [IpAddress](seabreeze-model-ipaddress.md) | IP address for the container group.<br/> |
| [OperatingSystemTypes enum](seabreeze-model-operatingsystemtypes.md) | Possible values include: 'Windows', 'Linux'<br/> |
| [OperationListResult](seabreeze-model-operationlistresult.md) | Describes the result of the request to list Service Fabric operations.<br/> |
| [OperationResult](seabreeze-model-operationresult.md) | Available operation list result<br/> |
| [ProxyResource](seabreeze-model-proxyresource.md) | The resource model definition.<br/> |
| [Resource](seabreeze-model-resource.md) | The resource model definition.<br/> |
| [ResourceLimits](seabreeze-model-resourcelimits.md) | The resource limits.<br/> |
| [ResourceRequests](seabreeze-model-resourcerequests.md) | The resource requests.<br/> |
| [ResourceRequirements](seabreeze-model-resourcerequirements.md) | The resource requirements.<br/> |
| [Volume](seabreeze-model-volume.md) | The volume definition for the container group.<br/> |
| [VolumeMount](seabreeze-model-volumemount.md) | The volume mount.<br/> |

