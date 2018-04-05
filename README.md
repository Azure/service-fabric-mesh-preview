---
title: Azure Service Fabric SeaBreeze overview and scope of the current preview.
description: Understand is SeaBreeze and what you can do with the current preview
services: Azure SeaBreeze
author: chackdan
manager: timlt

ms.service: SeaBreeze
ms.topic: Overview
ms.assetid:
ms.topic: article
ms.date: 04/2/2018
ms.author: chackdan
ms.editor: chackdan


---
# Service Fabric "SeaBreeze"

SeaBreeze is fully managed service where developers to build and deploy mission critical applications without managing any infrastructure such as VMs, storage, or networking. SeaBreeze is a serverless environment for applications built from microservices. 

![Seabreeze-01][Seabreeze-01]

Applications hosted on SeaBreeze can be scaled on demand without  developers worrying about the infrastructure needed to run their applications. The SeaBreeze service not only takes care of the physical infrastructure, but also detects and handles infrastructure failures, manages service discovery, data-partitioning, no-downtime upgrades, and other features that developers need from an application platform to building highly available and scalable applications. Developers win because they do not have to manage infrastructure, have a simple getting started experience, and can write  applications that automatically scale. Operations and IT managers win because they are billed only for resources they’re using on a per second basis and have simpler deployments. 

SeaBreeze is an application platform for developing cloud-native applications built as microservices that are deployed in containers. SeaBreeze is powered by [Azure Service Fabric]((http://docs.microsoft.com/azure/service-fabric/.md)). Today companies on a path to application modernization build applications consisting of stateless or stateful microservices. SeaBreeze enables developers to build stateful services using either built-in low latency container volume drivers or reliable collections (dictionary, queue) that can be used with any programming mode, or framework. 

With SeaBreeze all services are deployed and managed in containers so that organizations can modernize and enhance existing applications, or build new applications using microservices approach. Smaller teams develop a service that focuses on a scenario and independently test, version, deploy, and scale each microservice so that the entire application evolves over time.

## Infrastructure
SeaBreeze consists of clusters of thousands of machines at geo-scale that can span not only Azure zones, but also regions for high availability and reliability. These clusters run applications packed efficiently based on resources required. The applications are orchestrated as load changes or failures occur.  You only care about the health and responsiveness of the containers associated with your applications.  You upload code specifying scale, HA requirements, resource limits and SeaBreeze takes care of reliably running your code and the microbilling for the resources requested. 

## Roadmap

In order to make the public preview successful, we need your help. Each private preview release leading up to a public preview, will add more features. The feedback you provide will impact the private releases. All the private previews are free, but will be quota limited. More details will be provided as we roll out each preview. 

As we progress with the previews, we will update this page to include more details on the feature set. The plan is to have Private Preview 2 and Private Preview 3 before the public preview announcement. 

Here are some of the features you can expect to evaluate and provide feedback on. 

- Azure Resource Manager or CLI deployments
- Service Mesh for communication
- Persistence with volume drivers
- Visual Studio integration
- Ability to scale in/out services
- Reliable Collections for statefulness
- Cross-zone deployments for HA

## Private Preview 2 Capabilities 

This released is focused on getting feedback on SeaBreeze application model (aka. Service Fabric Application Model v2). This application model is a simple, unified way of running applications on SeaBreeze and on Service Fabric clusters. It is optimized for server-less multi-tenant execution environment (aka. SeaBreeze), however supported natively in Service Fabric platform. The applications written using this model will be able to run in SeaBreeze as well as on one box development, standalone, and SFRP clusters. In private preview 2, this application model is only available on SeaBreeze platform. In future releases you will be able to build and test SeaBreeze applications on the local development cluster as well as deploy them on single tenant clusters in Azure (SFRP clusters) or on on-premise (Standalone Clusters).

## Preview Limitations
As you are testing and providing feedback on this SeaBreeze Private Preview please be mindful of the following limitations:

* The max core count per application is limited to 6 (You can deploy 6 containers of 1 core each or 12 containers of 1/2 core each)
* The max core count per container cannot exceed 2. 
* The number of parallel applications you have running should be kept to around 5. You'll need to delete your application deployments when you are not actively working with it.

Here is the [Service Fabric SeaBreeze preview EULA](http://aka.ms/seabreezeprevieweula).

## Getting Started
Here is how you can get started:

1. Deploy an application to SeaBreeze using our [quickstart guide](./docs/conceptual-docs/application-deployment-quickstart.md).

2. Read about the [Application Model](./docs/conceptual-docs/appmodel-overview.md) and learn about how to achieve particular scenarios and deploy examples on SeaBreeze. 

3. Browse through SeaBreeze [documentation](./docs/README.md).

## Frequently asked questions and known Issues
[Frequently asked questions and known issues](./docs/conceptual-docs/FAQ-and-KnownIssues.md) with this private preview.

## Feedback
We look forward to hearing your feedback about SeaBreeze. Please use this repo's [Issues](https://github.com/Azure/seabreeze-preview-pr/issues) to inform us of any bugs you come across, or improvements you would like to request. 

<!-- Images -->
[SeaBreeze-01]: ./media/SeaBreeze.PNG
[Milestones]: ./media/Milestones.PNG

# Contributing to this project

This project has adopted the
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any
additional questions or comments.
