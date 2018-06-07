# Mesh Resource Provider API Reference

Service Fabric Mesh is the Service Fabric's serverless offering to enable developers to deploy containerized microservices applications without managing infrastructure.

Following is a list of Mesh Resource Provider REST APIs to deploy and manage containerized microservices applications. 


----
## [Applications APIs](mesh-index-applications.md)

| Name | Description |
| --- | --- |
| [Create](mesh-api-application_create.md) | Creates or updates an application resource.<br/> |
| [Get](mesh-api-application_get.md) | Gets the application resource.<br/> |
| [Delete](mesh-api-application_delete.md) | Deletes the application resource.<br/> |
| [List By Resource Group](mesh-api-application_listbyresourcegroup.md) | Gets all the application resources in a given resource group.<br/> |
| [List By Subscription](mesh-api-application_listbysubscription.md) | Gets all the application resources in a given subscription.<br/> |

----
## [Services APIs](mesh-index-services.md)

| Name | Description |
| --- | --- |
| [List By Application Name](mesh-api-service_listbyapplicationname.md) | Gets services of a given application.<br/> |
| [Get](mesh-api-service_get.md) | Gets the properties of the service.<br/> |

----
## [Replicas APIs](mesh-index-replicas.md)

| Name | Description |
| --- | --- |
| [List By Service Name](mesh-api-replica_listbyservicename.md) | Gets replicas of a given service.<br/> |
| [Get](mesh-api-replica_get.md) | Gets a specific replica of a given service.<br/> |

----
## [ContainerLogs APIs](mesh-index-containerlogs.md)

| Name | Description |
| --- | --- |
| [Get Container Log](mesh-api-codepackage_getcontainerlog.md) | Gets the logs for the container.<br/> |

----
## [Operations APIs](mesh-index-operations.md)

| Name | Description |
| --- | --- |
| [List](mesh-api-operations_list.md) | Lists all of the available operations.<br/> |

----
## [Networks APIs](mesh-index-networks.md)

| Name | Description |
| --- | --- |
| [Create](mesh-api-network_create.md) | Creates or updates a network resource.<br/> |
| [Get](mesh-api-network_get.md) | Gets the network resource.<br/> |
| [Delete](mesh-api-network_delete.md) | Deletes the network resource.<br/> |
| [List By Resource Group](mesh-api-network_listbyresourcegroup.md) | Gets all the network resources in a given resource group.<br/> |
| [List By Subscription](mesh-api-network_listbysubscription.md) | Gets all the network resources in a given subscription.<br/> |

----
## [Volumes APIs](mesh-index-volumes.md)

| Name | Description |
| --- | --- |
| [Create](mesh-api-volume_create.md) | Creates or updates a volume resource.<br/> |
| [Get](mesh-api-volume_get.md) | Gets the volume resource.<br/> |
| [Delete](mesh-api-volume_delete.md) | Deletes the volume resource.<br/> |
| [List By Resource Group](mesh-api-volume_listbyresourcegroup.md) | Gets all the volume resources in a given resource group.<br/> |
| [List By Subscription](mesh-api-volume_listbysubscription.md) | Gets all the volume resources in a given subscription.<br/> |

----
## [Models](mesh-index-models.md)

| Name | Description |
| --- | --- |
| [ApplicationProperties](mesh-model-applicationproperties.md) | This type describes properties of an application resource.<br/> |
| [ApplicationResourceDescription](mesh-model-applicationresourcedescription.md) | This type describes an application resource.<br/> |
| [ApplicationResourceDescriptionList](mesh-model-applicationresourcedescriptionlist.md) | A pageable list of application resources.<br/> |
| [ApplicationResourceProperties](mesh-model-applicationresourceproperties.md) | This type describes properties of an application resource.<br/> |
| [ApplicationResourceStatus enum](mesh-model-applicationresourcestatus.md) | Possible values include: 'Invalid', 'Ready', 'Upgrading', 'Creating', 'Deleting', 'Failed'<br/> |
| [AvailableOperationDisplay](mesh-model-availableoperationdisplay.md) | An operation available at the listed Azure resource provider.<br/> |
| [AzureInternalMonitoringPipelineSinkDescription](mesh-model-azureinternalmonitoringpipelinesinkdescription.md) | Diagnostics settings for Geneva.<br/> |
| [ContainerCodePackageProperties](mesh-model-containercodepackageproperties.md) | Describes a container and its runtime properties.<br/> |
| [ContainerEvent](mesh-model-containerevent.md) | A container event.<br/> |
| [ContainerInstanceView](mesh-model-containerinstanceview.md) | Runtime information of a container instance.<br/> |
| [ContainerLogs](mesh-model-containerlogs.md) | The logs of the container.<br/> |
| [ContainerState](mesh-model-containerstate.md) | The container state.<br/> |
| [ContainerVolume](mesh-model-containervolume.md) | Describes how a volume is attached to a container.<br/> |
| [DiagnosticsDescription](mesh-model-diagnosticsdescription.md) | Describes the diagnostics options available<br/> |
| [DiagnosticsRef](mesh-model-diagnosticsref.md) | Reference to sinks in DiagnosticsDescription.<br/> |
| [DiagnosticsSinkKind enum](mesh-model-diagnosticssinkkind.md) | The kind of DiagnosticsSink.<br/> |
| [DiagnosticsSinkProperties](mesh-model-diagnosticssinkproperties.md) | Properties of a DiagnosticsSink.<br/> |
| [EndpointProperties](mesh-model-endpointproperties.md) | Describes a container endpoint.<br/> |
| [EnvironmentVariable](mesh-model-environmentvariable.md) | Describes an environment variable for the container.<br/> |
| [ErrorModel](mesh-model-errormodel.md) | The error details.<br/> |
| [HealthState enum](mesh-model-healthstate.md) | The health state of a resource such as Application, Service, or Network.<br/> |
| [ImageRegistryCredential](mesh-model-imageregistrycredential.md) | Image registry credential.<br/> |
| [IngressConfig](mesh-model-ingressconfig.md) | Describes public connectivity configuration for the network.<br/> |
| [IngressQoSLevel enum](mesh-model-ingressqoslevel.md) | Possible values include: 'bronze'<br/> |
| [Layer4IngressConfig](mesh-model-layer4ingressconfig.md) | Describes the layer4 configuration for public connectivity for this network.<br/> |
| [ManagedProxyResource](mesh-model-managedproxyresource.md) | The resource model definition for Azure Resource Manager proxy resource. It will have everything other than required location and tags. This proxy resource is explicitly created or updated by including it in the parent resource.<br/> |
| [NetworkProperties](mesh-model-networkproperties.md) | Describes a network.<br/> |
| [NetworkRef](mesh-model-networkref.md) | Describes a network reference in a service.<br/> |
| [NetworkResourceDescription](mesh-model-networkresourcedescription.md) | This type describes a network resource.<br/> |
| [NetworkResourceDescriptionList](mesh-model-networkresourcedescriptionlist.md) | A pageable list of network resources.<br/> |
| [NetworkResourceProperties](mesh-model-networkresourceproperties.md) | Describes properties of a network resource.<br/> |
| [OperatingSystemTypes enum](mesh-model-operatingsystemtypes.md) | Possible values include: 'windows', 'linux'<br/> |
| [OperationListResult](mesh-model-operationlistresult.md) | Describes the result of the request to list Service Fabric operations.<br/> |
| [OperationResult](mesh-model-operationresult.md) | List of operations available at the listed Azure resource provider.<br/> |
| [ProvisionedResourceProperties](mesh-model-provisionedresourceproperties.md) | Describes common properties of a provisioned resource.<br/> |
| [ProxyResource](mesh-model-proxyresource.md) | The resource model definition for Azure Resource Manager proxy resource. It will have everything other than required location and tags.<br/> |
| [Resource](mesh-model-resource.md) | The resource model definition for Azure Resource Manager resource.<br/> |
| [ResourceLimits](mesh-model-resourcelimits.md) | This type describes the resource limits for a given container. It describes the most amount of resources a container is allowed to use before being restarted.<br/> |
| [ResourceRequests](mesh-model-resourcerequests.md) | This type describes the requested resources for a given container. It describes the least amount of resources required for the container. A container can consume more than requested resources up to the specified limits before being restarted. Currently, the requested resources are treated as limits.<br/> |
| [ResourceRequirements](mesh-model-resourcerequirements.md) | This type describes the resource requirements for a container or a service.<br/> |
| [ServiceList](mesh-model-servicelist.md) | A pageable list of all services in an application.<br/> |
| [ServiceReplicaDescription](mesh-model-servicereplicadescription.md) | This type describes a replica of a service resource.<br/> |
| [ServiceReplicaList](mesh-model-servicereplicalist.md) | A pageable list of replicas of a service resource.<br/> |
| [ServiceReplicaProperties](mesh-model-servicereplicaproperties.md) | Describes the properties of a service replica.<br/> |
| [ServiceResourceDescription](mesh-model-serviceresourcedescription.md) | This type describes a service resource.<br/> |
| [ServiceResourceProperties](mesh-model-serviceresourceproperties.md) | This type describes properties of a service resource.<br/> |
| [TrackedResource](mesh-model-trackedresource.md) | The resource model definition for Azure Resource Manager tracked top-level resource.<br/> |
| [VolumeProperties](mesh-model-volumeproperties.md) | This type describes properties of a volume resource.<br/> |
| [VolumeProviderParametersAzureFile](mesh-model-volumeproviderparametersazurefile.md) | This type describes a volume provided by an Azure Files file share.<br/> |
| [VolumeResourceDescription](mesh-model-volumeresourcedescription.md) | This type describes a volume resource.<br/> |
| [VolumeResourceDescriptionList](mesh-model-volumeresourcedescriptionlist.md) | A pageable list of volume resources.<br/> |
| [VolumeResourceProperties](mesh-model-volumeresourceproperties.md) | Describes properties of a volume resource.<br/> |

