---
title: Azure Service fabric SeaBreeze overview
description: Understand what the SeaBreeze offering is
services: Azure SeaBreeze
author: chackdan
manager: timlt

ms.service: SeaBreeze
ms.topic: overview
ms.date: 01/24/2018
ms.author: chackdan
ms.custom: mvc
---

# Service Fabric "SeaBreeze"

SeaBreeze is fully managed service enabling developers to deploy containerized applications without managing VMs, storage or networking (hidden infrastructure at geo-scale), while still allowing access to powerful runtime features and programming models. 

Applications hosted on SeaBreeze can be scaled on demand without the developers worrying about the infrastructure needed to run their applications. The SeaBreeze managed service not only takes care of the physical infrastructure, but also detects and handles infrastructure failures, and manages service discovery, data-partitioning, no-downtime upgrades and other features that developers need from an application platform when building highly available and scalable applications. Developers win because they do not have to manage infrastructure and have a simple getting started experience, and get to write powerful applications that automatically scale. Operations and IT managers win because they are billed only for resources they’re using on a very granular level and easy deployment of their containerized applications. 

SeaBreeze is a great application runtime platform for fast on-boarding of cloud-native applications, as well as a great container runtime when you need to develop generic low-level containers. Today we are seeing many companies on a path to application modernization to provide a service. Services can be stateless or stateful. Sea Breeze enables developers to easily build stateful services using either built-in low latency container volume drivers or reliable collections (dictionary, queue, etc) that can be used with any programming model or framework. 
In Sea Breeze all services are deployed and managed in containers so that organizations can modernize and enhance existing applications with new micro-services, or build new applications with a micro-services approach.  Smaller teams develop a service that focuses on a scenario and independently test, version, deploy, and scale each service so that the entire application can evolve.

SeaBreeze is powered by Azure Service fabric




## Next steps

Try deploying a container to Azure with a single command using our [quickstart guide](container-group-set-quickstart.md).