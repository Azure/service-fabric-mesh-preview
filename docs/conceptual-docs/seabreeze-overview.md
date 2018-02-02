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

In order to make the public preview true to its promise and vision, we need your help. We will start with a few limited private preview releases every four weeks or so, leading up to a public preview, with each refresh adding more cutting edge features. As participants in the preview, we expect that you will  actively try things out and provide feedback. The feedback you provide will directly impact the experience by accommodating features that matter to you.

This all private previews are free (you don’t pay for anything including underlying resources), but will be quota limited. More details will be provided once you are on-boarded. 

As we progress along the previews, we will update this page to include more details on the feature set.

Here are some of the features you can expect to evaluate and provide feedback along the way. 

![Milestones]
## Private preview 1 capabilities 

This release is mainly targeted at getting feedback on the basic building blocks of the SeaBreeze service - the Container Group Set (CGS)* resource. The ability to provision 1 to N containers (or a Container Group) on demand, using CLI, ARM deployment or REST. Each CGS gets a public VIP and DNS for the CGS instances. 

## Introducing Container Group Set resource.

All deployments into SeaBreeze are in containers and as an implementation detail, the most granular deployment block for an application or service deployed into SeaBreeze is the Container Group Set (CGS)* resource.

A *Container Group (CG) is a group of one or more containers (such as Docker containers), with shared storage/network, and a specification for how to run the containers. A container groups contents are always co-located and co-scheduled and run in a shared context. A Container Group models an application-specific “logical host” - it contains one or more application containers which are relatively tightly coupled — in a pre-container world, they would have executed on the same physical or virtual machine. 

The *Container Group Set (CGS) is an ARM resource, which allows the customer to request 1 to N instances of a Container Group (CG). 

For more details on how to deploy a container group resource, refer to our [quickstart guide](container-group-set-quickstart.md).

## Scenarios enabled in private preview 1

- “Lift and Shift” existing applications into containers (modernize)
- Build new microservice applications in containers (greenfield) 

## "I can" Statements for private preview 1

- I can develop and deploy a new containerized application using services (aka CGS)
- I can delete the services (aka CGS) resource
- I can view the running status of my Services/CGS and its instances. 
- I can specify a volume driver for my containers, so that my container state is not lost, when azure fails over my container to a new host. 
- I can add multiple containers in a service to enable side care services (aka CGS) like a watch dog.  
- I can update a deployed service by deploying the updated services (aka CGS) definition (the system deploys new and removes old)

## "I can" Statements planned for public preview

The following are some of the high level "I can" statements, we plan to enable along the way to public preview and GA. The list is not exhaustive and are a representative sample to help you plan for the usage in your projects/applications. As we progress along the private previews leading up to the public preview, you should see the list of these capabilities move up to be in the previews. If we determine that a certain feature has not reached the preview quality by the release date, then we would move it to the next release.

- I can Deploy/Modify/Delete an application with one or more containerized services (which in turn might have 1 or more containers each)  using a CLI or Powershell or REST APIs or Portal 
- I can use the SeaBreeze application model that specifies services within  (manifest.yaml) 
- I can add a storage volume to my containers including the built-in SF volume driver and Azure Files and also support for managed disks
- I can connect to other Azure services from my applications.
- I get streams of monitoring (metrics) and diagnostic (logs) data per container  (optionally by services and application) without requiring the me explicitly instrumenting my code  
- I can see my application diagnostics and monitoring information by default in AI. The default AI tier gives me the metrics, logs and traces for the last n days. 
- I can route my application diagnostics and monitoring information to any tool of my choice.
- I can deploy Linux and Windows (Hyper-V) containers.  
- I can specify the certificates  in the application.yaml and I can use them inside my container.
- I can deploy my container (100 MB image) and be up and running in 8 seconds. The measurement starts on request for deployment to when an end is available. 
- I pay only for the resources (CPU, MEM, transactions/storage for replicated store) I request in the container/application definition in per second interval and able to view the breakdown on the portal
- I can use service names specified in the application.yaml to communicate between my services.
- I can use the IP addresses from my existing vNet to deploy my containers.– “Bring your own vNet”  scenario
- For my services, I can specify if they are public (I get a public IP+port), private (accessible by other services in the app), or shared (two or more apps sharing the VNET)
- I can specify auto scale rules for services that make up my application.
- I can get automatic SSL termination
- I can remote into a container for debugging
- I can see an application map of communications between services in portal
- I can perform Snap-shot debugging on my  .netcore applications in the portal.
- I am can use Service Fabric reliable collections programming  model for statefull services in C#, nodeJS and  Java.
- I can use visual studio tooling to create/debug/deploy/delete/modify applications with ease.
- I can leverage the SeaBreeze Market place for solutions very similar to what I can do with the Kubernetes.
- I can use the SeaBreeze package creation tool to easily create the deployment package (and manifest) for my application.
- My containers run is an isolated (network and compute) environment, and I do not have to worry about getting affected by a nosy or noisy neighbor.
- I can use the free tier in SeaBreeze to try out new applications.
- I can deploy Application, Service and Container Group set as ARM resources
- All infrastructure for SeaBreeze is invisible to me  and I am not worried about capacity planning
- I can deploy my Tier1 apps to SeaBreeze, since the platform is already complaint with all the industry complaince standards that Azure supports
- I can easy create new applications and manage them with confidence, thanks to the excellent samples, documentation that the SeaBreeze team has provided
- I can perform Blue/Green deployments in SeaBreeze.  I can also choose to route a part of my production deployments to a Green deployment, before I decide to switch to it/ or not.
- I can subscribe to automatic backup for by statefull containers, when using service fabric simplified programming models (reliable collections and actors)
- I can have my application more only deployed across azure zones, but also across geo-political regions to achieve an RPO and RTO = 0.


## Next steps

Try deploying a container /container Group to Azure with a single command using our [quickstart guide](container-group-set-quickstart.md).

<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG