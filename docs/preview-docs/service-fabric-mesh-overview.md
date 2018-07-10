---
title: Overview of Azure Service Fabric Mesh
description: An overview of Azure Service Fabric Mesh. With Service Fabric Mesh, you can deploy and scale your application without worrying about the infrastructure needs of your application.
services: Azure Service Fabric Mesh
keywords: 
author: rwike77
ms.author: ryanwi
ms.date: 06/27/2018
ms.topic: overview
ms.service: service-fabric-mesh
manager: timlt
#Customer intent: As a developer, I want to deploy and manage services in containers on a serverless platform.
---

# What is Service Fabric Mesh?

Azure Service Fabric Mesh is a fully managed service that enables developers to deploy microservices applications without managing virtual machines, storage, or networking. Applications hosted on Service Fabric Mesh run and scale without you worrying about the infrastructure powering it.  Service Fabric Mesh consists of clusters of thousands of machines.  All cluster operations are hidden from the developer. Simply upload your code and specify resources you need, availability requirements, and resource limits.  Service Fabric Mesh automatically allocates the infrastructure requested by your application deployment and also handles infrastructure failures, making sure your applications are highly available. You only need to care about the health and responsiveness of your application, not the infrastructure.  

[!INCLUDE [preview note](./includes/include-preview-note.md)]

This article provides an overview of the key benefits of Service Fabric Mesh.

## Great developer experience

Tooling in Visual Studio and Visual Studio Code provides a powerful editing and debugging experience.  Multiple programing languages and frameworks are supported, giving you the ability to create applications that run any code.

With Service Fabric Mesh you can:

- "Lift and shift" existing applications into contianers to modernize and run your current applications at scale. 
- Build and deploy new microservices applications at scale in Azure.  Integrate with other Azure services or existing applications running in containers. Each microservice is part of a secure, network isolated application with resource governance policies defined for CPU cores, memory, disk space, and more.
- Integrate with and extend existing applications without making changes to those applications. Use your own virtual network to connect existing application to the new application.  
- Modernize your existing Cloud Services applications by migrating to Service Fabric Mesh.  

## Simple operational lifecycle

Easily manage running applications, including application upgrades and versioning, monitoring applications and debugging in production environments. These applications can consist of a single microservice or multiple microservices isolated within their own network. Applications run efficiently with fast deployment, placement, and failover times.

With Service Fabric Mesh you can:

- Deploy and manage applications without having to explicitly provision and manage infrastructure.  Service Fabric Mesh provisions, upgrades, patches, and maintains the underlying infrastructure for you.
- Setup continuous integration using the integrated tooling to easily package and deploy applications.
- Leverage all the features of Azure Resource Manager resources (for example, audit trail and [role-based access control (RBAC)](/azure/role-based-access-control/overview)) because all the resources  (like Applications, Services, Secrets etc) you deploy to SF Mesh service in Azure are Azure Resource Manager resources. 
- Deploy and manage resources using the [Azure portal](https://portal.azure.com), Resource Manager templates, or Azure CLI/PowerShell libraries.
- Set up operational monitoring and alerting using [Application Insights](/azure/application-insights/) (or your tool of choice) to capture operational and diagnostic traces from the platform. 
- Access application diagnostics information emitted from the application model using [Application Insights](/azure/application-insights/) or your tool of choice.
- Optimize resources usage by specifying auto-scale rules for the services in the application definition.  (coming soon)
- Create network isolation and security boundaries for applications, a powerful feature when combined with Hyper-V containers. Isolate the network traffic to and from the services using multiple IPs per service and isolated virtual networks per application.  (coming soon) 


## Mission critical platform capabilities

Service Fabric Mesh creates a collection of clusters that span [Azure Availability Zones](/azure/availability-zones/az-overview) and/or geo-political regional boundaries. Applications are described with a set of intents such as scale, hardware requirements, durability requirements, and security policies.  When the application deploys, Service Fabric Mesh finds the optimal place to run it.

With Service Fabric Mesh you can:

- Take advantage of high availability, scaling in/out, discoverability, orchestration, message routing, reliable messaging, no-downtime upgrades, security/secrets management, disaster recovery, state management, configuration management, and distributed transactions.
- Choose between multiple application models when creating applications.
- Use platform capabilities exposed through REST endpoints by consuming language-specific bindings generated using Swagger.
- Deploy applications across [Availability Zones](/azure/availability-zones/az-overview) and multiple regions for geo-reliability.
- Use all the security and compliance features that Azure provides.

## Next steps

It only takes a few steps to deploy a sample project with Visual Studio. For more information, see [Create an ASP.NET Core website](service-fabric-mesh-quickstart-dotnet-core.md). 


<!-- Links -->

[service-fabric-overview]: ../service-fabric/service-fabric-overview.md
