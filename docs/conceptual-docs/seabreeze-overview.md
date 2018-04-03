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

SeaBreeze is fully managed service enabling developers to build and deploy mission critical applications without managing any infrastructure such as VMs, storage or networking. SeaBreeze is a serverless environment for applications built from microservices. 

![Seabreeze-01][Seabreeze-01]

Applications hosted on SeaBreeze can be scaled on demand without  developers worrying about the infrastructure needed to run their applications. The SeaBreeze service not only takes care of the physical infrastructure, but also detects and handles infrastructure failures, manages service discovery, data-partitioning, no-downtime upgrades and other features that developers need from an application platform to building highly available and scalable applications. Developers win because they do not have to manage infrastructure, have a simple getting started experience, and can write  applications that automatically scale. Operations and IT managers win because they are billed only for resources they’re using on a per second basis and have simpler deployments. 

SeaBreeze is an application platform for developing cloud-native applications built as microservices which are deployed in containers. SeaBreeze is powered by [Azure Service Fabric]((http://docs.microsoft.com/azure/service-fabric/.md)). Today companies on a path to application modernization build applications consisting of stateless or stateful microservices. SeaBreeze enables developers to  build stateful services using either built-in low latency container volume drivers or reliable collections (dictionary, queue) that can be used with any programming model or framework. 

In SeaBreeze all services are deployed and managed in containers so that organizations can modernize and enhance existing applications with new microservices, or build new applications with a microservices approach. Smaller teams develop a service that focuses on a scenario and independently test, version, deploy, and scale each microservice so that the entire application evolves over time.

## Infrastructure
SeaBreeze consists of clusters of thousands of machines at geo-scale that can span not only Azure zones, but also regions for high availability and reliability. These clusters run applications packed efficiently based on resources required. The applications are orchestrated as load changes or failures occur.  You only care about the health and responsiveness of the containers associated with your applications.  You upload code specifying scale, HA requirements, resource limits and 
SeaBreeze takes care of reliably running your code and the microbilling for the resources requested. Because the hardware infrastructure and the notion of the cluster itself are hidden from developers, we say that SeaBreeze is a serverless platform.

## Road Map

In order to make the public preview true to its promise and vision, we need your help. Each private preview release leading up to a public preview, will add more features. The feedback you provide will impact the private releases. All the private previews are free, but will be quota limited. More details will be provided as we roll out each previews. 

As we progress along the previews, we will update this page to include more details on the feature set. The plan is to have Private Preview 2 and Private Preview 3 before the public preview annoucement. 

Here are some of the features you can expect to evaluate and provide feedback on. 

- ARM or CLI deployments
- Service Mesh for communication
- Persistence with volume drivers
- Visual Studio integration
- Ability to scale in/out services
- Reliable Collections for statefulness
- Cross-zone deployments for HA


## Private Preview 2 capabilities 

This release is mainly targeted at getting feedback on the application model for SeaBreeze. The application model allows you to define an application, services and a network via a manifest JSON file. Currently all the resources are placed into a single file called a deployment.

These are the commands in this preview:

* Group
    *   az sbz: (PREVIEW) Manage Azure SeaBreeze Resources.

Subgroups:
*    app           : Manage SeaBreeze applications.
*   codepackage   : Manage SeaBreeze service replica code packages.
*    deployment    : Manage SeaBreeze deployments.
*    network       : Manage networks.
*    service       : Manage SeaBreeze services.
*    servicereplica: Manage SeaBreeze service replicas.
*    volume        : Manage volumes.

## Service Fabric Applications 

Service Fabric applications are a declarative way of running applications on SeaBreez. You write an application in any language/framework of your choice, describe how it should run in a YAML or JSON definition and deploy this to Azure. For more details read
[ application model](application-model-scenarios.md) doc. 

### Scenarios enabled in private previews 
The primary scenarios for the private previews are;

- Modernize existing applications (lift and shift)
- Build new microservice applications (greenfield) 

### Example applications.
For example applications demonstrating the scenarios above, see the samples folder in the github repo.

## Frequently asked questions and known Issues

[Frequently asked questions and known issues](./FAQ-and-KnownIssues.md) with this private preview.


## Getting Started
Here is how you can get started:

1. Deploy an application to SeaBreeze using our [quickstart guide](application-deployment-quickstart.md).
2. Read about the  [Application Model scenarios](application-model-scenarios.md) and deploy sample applications

<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG