---
title: SeaBreeze Application Model
description: Overview and scenarios for the SeaBreeze Application Model
services: Azure SeaBreeze
author: chackdan;vipulm;bharathn
manager: vipulm

ms.service: SeaBreeze
ms.topic: overview
ms.assetid:
ms.topic: article
ms.date: 03/26/2018
ms.author: chackdan;vipulm;bharathn
ms.editor: chackdan;vipulm;bharathn
---
# SeaBreeze Application Model

## Overview
Service Fabric Application Model v2 is a simple, unified way of running applications on SeaBreeze and on Service Fabric clusters. The model is optimized for server-less multi-tenant execution environment (aka. SeaBreeze), however supported natively in Service Fabric platform. The applications written using this model will be able to run in SeaBreeze as well as on one box development, standalone, and SFRP clusters.

In summary, Service Fabric Application Model v2 is:
- suitable for server-less, multi-tenant environment
- a simplification of the current Service Fabric application model
- a natural model for expressing any micro-services based applications (not just the ones that use Service Fabric's reliable service and reliable actor programming model)

## Model

Service Fabric Application Model v2 is resource-based. 

At present, the following top-level resources are supported. 

- Application
- Service
- Network
- Volume

The future releases will add support for following additional top-level resources.
- Secret
- Service Mesh Router

### Application

An application is a collection of constituent services that perform a certain function or functions. The lifecycle of each application instance can be managed independently. For example, one application can be upgraded independently from other application. 

### Service

A service performs a complete and standalone function. It can start and run independently of other services. 

Service is composed of one or more code packages and configuration for those code packages.

A code package is a container image with the version tag and resources required for that container. 

Service is also a unit of deployment and activation. All container code packages of a service are part of the pod and share same namespace. They can communicate with each other using localhost. 

Service can scale out by increasing its `replicaCount`. Scaling out would increase the number of running container instances for each code package.

Services can attach themselves to one or more network resources. All containers in that service will be able to communicate with any other services or external endpoints that are part of that network.

### Network

Use network resource to create private network and configure public connectivity for services within the application.

More than one service from different applications can be part of the same network.

### Volume

Use volume resource to define properties for a volume that needs to be mounted inside the container of a service.

## Scenarios

Following is the list of common scenarios supported by Service Fabric Application Model v2. 
