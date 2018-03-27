---
title: Application model scenarios and use cases
description: Some of the scenarios and use cases that you can leverage application model for
services: Azure SeaBreeze
author: chackdan;vipulm;bharathn
manager: timlt

ms.service: SeaBreeze
ms.topic: overview
ms.assetid:
ms.topic: article
ms.date: 03/26/2018
ms.author: chackdan
ms.editor: chackdan
---

# SeaBreeze Application Model scenarios 

Service Fabric Applications is a simple, unified way of running applications on Service Fabric. Users simply write an application in any language or platform, describe how it should run in a simple YAML or JSON definition, and run it on any of the three product SKUS of Service Fabric (Seabreeze, on-premise cluster or Azure SF cluster).

A Service Fabric application can be made up of different resource types such as:

- 	Applications and services
- 	Secrets 
- 	Networks
- 	Volumes

A resource describes how something should run. For example, a service resource describes the name of a container image, how many copies to run, environment variables, etc. A volume resource describes the volume provider, account information, etc. 

This document will walk you through some of the scenarios and use cases that you can leverage when setting up your applications and deploying them to SeaBreeze. Although the application model will 
support YAML and a local one-box experience, this document for now will be focused on providing you sample JSON that you can use to deploy your application to SeaBreeze (onAzure). 

**Note:** In preview 2, your deployment scenarios are restricted to a quota allocated to you, refer to the FAQ document on Quota details.


## 1. Create a micro-service composed of multiple code packages that can be scaled from 1 to N instances

#### An application with one micro-service,with no external communication and uses a private container image  

In this scenario the application has a service whose code packages are packaged as container images and the containers can communicate with each other using localhost.

The Sample JSON is available at [sbz_rp.json](./application-model-scenario-examples/1.1/sbz_rp.json)


#### An application with one micro-service, that communicates via an external IP and uses a private container image  

In this scenario the application has following characteristics 


- A service whose code packages are packaged as container images.
- Containers can communicate with each other using localhost
- One of the containers listens on an external end point on a specific port.(Create a load balanced TCP port and forward traffic to an endpoint of the microservice)
- Container images are located in a secure repository that needs credentials

The Sample JSON is available at [sbz_rp.json](./application-model-scenario-examples/1.3/sbz_rp.json)

#### 2. An application with two micro-services, once exposed publically. Services communicate to each other using DNS. Also uses Azure files are a volume driver to store state.

In this scenario the application has following characteristics 


- Has two services, Frontend and Backend communicating via DNS
- Two service whose code packages are packaged as container images.
- Containers in each service can communicate with each other using localhost
- Container images are in a secure registry and so need credentials
- Uses the Azure File Share as a volume to store state.

The Sample JSON is available at [sbz_rp.json](./application-model-scenario-examples/2.1/sbz_rp.json)



<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG


