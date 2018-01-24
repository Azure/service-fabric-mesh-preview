---
title: Container group set quick start guide
description: Quick start guide on deploying Container Group Set.
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
# Container Group Sets

All deployments into SeaBreeze are in containers and as an implementation detail, the most granular deployment block for an application or service deployed into SeaBreeze is the Container Group Set (CGS)* resource.

A *Container Group (CG) is a group of one or more containers (such as Docker containers), with shared storage/network, and a specification for how to run the containers. A container groups contents are always co-located and co-scheduled and run in a shared context. A Container Group models an application-specific “logical host” - it contains one or more application containers which are relatively tightly coupled — in a pre-container world, they would have executed on the same physical or virtual machine. 

The *Container Group Set (CGS) is an ARM resource, which allows the customer to request 1 or N instances of a Container Group (CG). 

For more details on how to deploy a container group resource, refer to our [quickstart guide](container-group-set-quickstart.md).

![Milestones]


## Next steps

Try deploying a container /container Group to Azure with a single command using our [quickstart guide](container-group-set-quickstart.md).

<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG