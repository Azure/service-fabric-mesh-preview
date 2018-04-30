

# SeaBreeze Resource Provider API Reference

Service Fabric SeaBreeze is the Service Fabric's serverless offering to enable developers to deploy containerized microservices applications without managing infrastructure.

Following is a list of SeaBreeze Resource Provider REST APIs to deploy and manage containerized microservices applications. 


----
## [Applications APIs](seabreeze-index-applications.md)

| Name | Description |
| --- | --- |
| [Create](seabreeze-api-application_create.md) | Creates or updates an application resource.<br/> |
| [Get](seabreeze-api-application_get.md) | Gets the application resource.<br/> |
| [Delete](seabreeze-api-application_delete.md) | Deletes the application resource.<br/> |
| [List By Resource Group](seabreeze-api-application_listbyresourcegroup.md) | Gets all the application resources in a given resource group.<br/> |
| [List By Subscription](seabreeze-api-application_listbysubscription.md) | Gets all the application resources in a given subscription.<br/> |

----
## [Services APIs](seabreeze-index-services.md)

| Name | Description |
| --- | --- |
| [List By Application Name](seabreeze-api-service_listbyapplicationname.md) | Gets services of a given application.<br/> |
| [Get](seabreeze-api-service_get.md) | Gets the properties of the service.<br/> |

----
## [Replicas APIs](seabreeze-index-replicas.md)

| Name | Description |
| --- | --- |
| [List By Service Name](seabreeze-api-replica_listbyservicename.md) | Gets replicas of a given service.<br/> |
| [Get](seabreeze-api-replica_get.md) | Gets a specific replica of a given service.<br/> |

----
## [ContainerLogs APIs](seabreeze-index-containerlogs.md)

| Name | Description |
| --- | --- |
| [Get Container Log](seabreeze-api-codepackage_getcontainerlog.md) | Gets the logs for the container.<br/> |

----
## [Operations APIs](seabreeze-index-operations.md)

| Name | Description |
| --- | --- |
| [List](seabreeze-api-operations_list.md) | Lists all of the available operations.<br/> |

----
## [Networks APIs](seabreeze-index-networks.md)

| Name | Description |
| --- | --- |
| [Create](seabreeze-api-network_create.md) | Creates or updates a network resource.<br/> |
| [Get](seabreeze-api-network_get.md) | Gets the network resource.<br/> |
| [Delete](seabreeze-api-network_delete.md) | Deletes the network resource.<br/> |
| [List By Resource Group](seabreeze-api-network_listbyresourcegroup.md) | Gets all the network resources in a given resource group.<br/> |
| [List By Subscription](seabreeze-api-network_listbysubscription.md) | Gets all the network resources in a given subscription.<br/> |

----
## [Volumes APIs](seabreeze-index-volumes.md)

| Name | Description |
| --- | --- |
| [Create](seabreeze-api-volume_create.md) | Creates or updates a volume resource.<br/> |
| [Get](seabreeze-api-volume_get.md) | Gets the volume resource.<br/> |
| [Delete](seabreeze-api-volume_delete.md) | Deletes the volume resource.<br/> |
| [List By Resource Group](seabreeze-api-volume_listbyresourcegroup.md) | Gets all the volume resources in a given resource group.<br/> |
| [List By Subscription](seabreeze-api-volume_listbysubscription.md) | Gets all the volume resources in a given subscription.<br/> |

----
## [Models](seabreeze-index-models.md)

| Name | Description |
| --- | --- |
| [ApplicationProperties](seabreeze-model-applicationproperties.md) | This type describes properties of an application resource.<br/> |
| [ApplicationResourceDescription](seabreeze-model-applicationresourcedescription.md) | This type describes an application resource.<br/> |
| [ApplicationResourceDescriptionList](seabreeze-model-applicationresourcedescriptionlist.md) | A pageable list of application resources.<br/> |
| [ApplicationResourceProperties](seabreeze-model-applicationresourceproperties.md) | This type describes properties of an application resource.<br/> |
| [ApplicationResourceStatus enum](seabreeze-model-applicationresourcestatus.md) | Possible values include: 'Invalid', 'Ready', 'Upgrading', 'Creating', 'Deleting', 'Failed'<br/> |
| [AvailableOperationDisplay](seabreeze-model-availableoperationdisplay.md) | An operation available at the listed Azure resource provider.<br/> |
| [AzureInternalMonitoringPipelineSinkDescription](seabreeze-model-azureinternalmonitoringpipelinesinkdescription.md) | Diagnostics settings for Geneva.<br/> |
| [ContainerCodePackageProperties](seabreeze-model-containercodepackageproperties.md) | Describes a container and its runtime properties.<br/> |
| [ContainerEvent](seabreeze-model-containerevent.md) | A container event.<br/> |
| [ContainerInstanceView](seabreeze-model-containerinstanceview.md) | Runtime information of a container instance.<br/> |
| [ContainerLogs](seabreeze-model-containerlogs.md) | The logs of the container.<br/> |
| [ContainerState](seabreeze-model-containerstate.md) | The container state.<br/> |
| [ContainerVolume](seabreeze-model-containervolume.md) | Describes how a volume is attached to a container.<br/> |
| [DiagnosticsDescription](seabreeze-model-diagnosticsdescription.md) | Describes the diagnostics options available<br/> |
| [DiagnosticsRef](seabreeze-model-diagnosticsref.md) | Reference to sinks in DiagnosticsDescription.<br/> |
| [DiagnosticsSinkKind enum](seabreeze-model-diagnosticssinkkind.md) | The kind of DiagnosticsSink.<br/> |
| [DiagnosticsSinkProperties](seabreeze-model-diagnosticssinkproperties.md) | Properties of a DiagnosticsSink.<br/> |
| [EndpointProperties](seabreeze-model-endpointproperties.md) | Describes a container endpoint.<br/> |
| [EnvironmentVariable](seabreeze-model-environmentvariable.md) | Describes an environment variable for the container.<br/> |
| [ErrorModel](seabreeze-model-errormodel.md) | The error details.<br/> |
| [HealthState enum](seabreeze-model-healthstate.md) | The health state of a resource such as Application, Service, or Network.<br/> |
| [ImageRegistryCredential](seabreeze-model-imageregistrycredential.md) | Image registry credential.<br/> |
| [IngressConfig](seabreeze-model-ingressconfig.md) | Describes public connectivity configuration for the network.<br/> |
| [IngressQoSLevel enum](seabreeze-model-ingressqoslevel.md) | Possible values include: 'bronze'<br/> |
| [Layer4IngressConfig](seabreeze-model-layer4ingressconfig.md) | Describes the layer4 configuration for public connectivity for this network.<br/> |
| [ManagedProxyResource](seabreeze-model-managedproxyresource.md) | The resource model definition for Azure Resource Manager proxy resource. It will have everything other than required location and tags. This proxy resource is explicitly created or updated by including it in the parent resource.<br/> |
| [NetworkProperties](seabreeze-model-networkproperties.md) | Describes a network.<br/> |
| [NetworkRef](seabreeze-model-networkref.md) | Describes a network reference in a service.<br/> |
| [NetworkResourceDescription](seabreeze-model-networkresourcedescription.md) | This type describes a network resource.<br/> |
| [NetworkResourceDescriptionList](seabreeze-model-networkresourcedescriptionlist.md) | A pageable list of network resources.<br/> |
| [NetworkResourceProperties](seabreeze-model-networkresourceproperties.md) | Describes properties of a network resource.<br/> |
| [OperatingSystemTypes enum](seabreeze-model-operatingsystemtypes.md) | Possible values include: 'windows', 'linux'<br/> |
| [OperationListResult](seabreeze-model-operationlistresult.md) | Describes the result of the request to list Service Fabric operations.<br/> |
| [OperationResult](seabreeze-model-operationresult.md) | List of operations available at the listed Azure resource provider.<br/> |
| [ProvisionedResourceProperties](seabreeze-model-provisionedresourceproperties.md) | Describes common properties of a provisioned resource.<br/> |
| [ProxyResource](seabreeze-model-proxyresource.md) | The resource model definition for Azure Resource Manager proxy resource. It will have everything other than required location and tags.<br/> |
| [Resource](seabreeze-model-resource.md) | The resource model definition for Azure Resource Manager resource.<br/> |
| [ResourceLimits](seabreeze-model-resourcelimits.md) | This type describes the resource limits for a given container. It describes the most amount of resources a container is allowed to use before being restarted.<br/> |
| [ResourceRequests](seabreeze-model-resourcerequests.md) | This type describes the requested resources for a given container. It describes the least amount of resources required for the container. A container can consume more than requested resources up to the specified limits before being restarted. Currently, the requested resources are treated as limits.<br/> |
| [ResourceRequirements](seabreeze-model-resourcerequirements.md) | This type describes the resource requirements for a container or a service.<br/> |
| [ServiceList](seabreeze-model-servicelist.md) | A pageable list of all services in an application.<br/> |
| [ServiceReplicaDescription](seabreeze-model-servicereplicadescription.md) | This type describes a replica of a service resource.<br/> |
| [ServiceReplicaList](seabreeze-model-servicereplicalist.md) | A pageable list of replicas of a service resource.<br/> |
| [ServiceReplicaProperties](seabreeze-model-servicereplicaproperties.md) | Describes the properties of a service replica.<br/> |
| [ServiceResourceDescription](seabreeze-model-serviceresourcedescription.md) | This type describes a service resource.<br/> |
| [ServiceResourceProperties](seabreeze-model-serviceresourceproperties.md) | This type describes properties of a service resource.<br/> |
| [TrackedResource](seabreeze-model-trackedresource.md) | The resource model definition for Azure Resource Manager tracked top-level resource.<br/> |
| [VolumeProperties](seabreeze-model-volumeproperties.md) | This type describes properties of a volume resource.<br/> |
| [VolumeProviderParametersAzureFile](seabreeze-model-volumeproviderparametersazurefile.md) | This type describes a volume provided by an Azure Files file share.<br/> |
| [VolumeResourceDescription](seabreeze-model-volumeresourcedescription.md) | This type describes a volume resource.<br/> |
| [VolumeResourceDescriptionList](seabreeze-model-volumeresourcedescriptionlist.md) | A pageable list of volume resources.<br/> |
| [VolumeResourceProperties](seabreeze-model-volumeresourceproperties.md) | Describes properties of a volume resource.<br/> |

