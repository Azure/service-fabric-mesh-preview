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

#### 1.1 An application with one microservice,with no external communication or storage, simple compute

In this scenario the application Code Packages are packaged as container images and the Containers can communicate with each other using localhost.

For details refer to the [Readme](./application-model-scenario-examples/1.1/sbz_rp.json)
The Sample JSON is available at [sbz_rp.json](./application-model-scenario-examples/1.1/sbz_rp.json)





<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG

./conceptual-docs/application-model-scenario-examples/1.1/sbz_rp.json
