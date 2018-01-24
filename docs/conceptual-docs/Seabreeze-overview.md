---
title: Azure Service fabric SeaBreeze overview
description: Understand what the SeaBreeze offering is
services: Azure SeaBreeze
author: chackdan
manager: timlt

ms.service: SeaBreeze
ms.topic: overview
ms.assetid:
ms.topic: article
ms.date: 01/24/2018
ms.author: chackdan
ms.editor: chackdan


---
# Service Fabric "SeaBreeze"

SeaBreeze is fully managed service enabling developers to deploy containerized applications without managing VMs, storage or networking (hidden infrastructure at geo-scale), while still allowing access to powerful runtime features and programming models. 

![Seabreeze-01][Seabreeze-01]

Applications hosted on SeaBreeze can be scaled on demand without the developers worrying about the infrastructure needed to run their applications. The SeaBreeze managed service not only takes care of the physical infrastructure, but also detects and handles infrastructure failures, and manages service discovery, data-partitioning, no-downtime upgrades and other features that developers need from an application platform when building highly available and scalable applications. Developers win because they do not have to manage infrastructure and have a simple getting started experience, and get to write powerful applications that automatically scale. Operations and IT managers win because they are billed only for resources they’re using on a very granular level and easy deployment of their containerized applications. 

SeaBreeze is a great application runtime platform for fast on-boarding of cloud-native applications, as well as a great container runtime when you need to develop generic low-level containers. SeaBreeze is powered by [Azure Service fabric platform]((../service-fabric/service-fabric-overview.md).) and so inherits all the robustness of the battle hardened platform. Today we are seeing many companies on a path to application modernization to provide a service. Services can be stateless or stateful. Sea Breeze enables developers to easily build stateful services using either built-in low latency container volume drivers or reliable collections (dictionary, queue, etc) that can be used with any programming model or framework. 
In Sea Breeze all services are deployed and managed in containers so that organizations can modernize and enhance existing applications with new micro-services, or build new applications with a micro-services approach.  Smaller teams develop a service that focuses on a scenario and independently test, version, deploy, and scale each service so that the entire application can evolve.

## Infrastructure
SeaBreeze consists of clusters of thousands of machines at geo-scale that can span not only Azure zones, but also regions for high availability and reliability. These clusters run customers’ containers packed efficiently based on resources required. The containers are orchestrated automatically as load changes or failures occur.  All cluster operations are hidden from the customer. The customer only cares about the health and responsiveness of the containers associated with their applications.  Customer simply upload code specifying scale, HA requirements  (e.g. regional, availability zone (AZ) or geo-scale) and resource limits and the platform takes care of reliably running their code and microbilling for the resources requested. Because the hardware infrastructure and the notion of the cluster itself are hidden from developers, we say that SeaBreeze is not only a serverless, but a “clusterless” platform.

## Road Map to public preview.

In order to make the public preview true to its promise and vision, we need your help. We will start with a few limited preview releases every four weeks or so, leading up to a public preview, with each refresh adding more cutting edge features. As participants in the preview, we expect that you will  actively try things out and provide feedback. The feedback you provide will directly impact the experience by accommodating features that matter to you.

Here are some of the features you can expect to evaluate and provide feedback along the way. 

Every preview will have a goal, the first one is specifically to get feedback on the basic infrastructure unit of deployment and isolation - Containers and container Groups.

As we progress along the previews, we will update this page to include more details.

![Milestones]


## Next steps

Try deploying a container to Azure with a single command using our [quickstart guide](container-group-set-quickstart.md).

<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG