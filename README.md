# Azure Service Fabric Mesh - Private Preview 3

Azure Service Fabric Mesh is fully managed service where developers can build and deploy mission critical applications without managing any infrastructure such as VMs, storage, or networking. Mesh is a serverless environment for applications built from microservices.

## We need your feedback to get this right

![Feedback][Survey]

Please spend a few minutes and give some feedback on the Azure Service Fabric Mesh preview: [Preview survey](https://forms.office.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR358VaENw7hEnp4naVX-v5FUMVpMNzlSMTU4MTJTSEU2RzBHOFZLTk5PUC4u)

## What is Azure Service Fabric Mesh

Applications hosted on Mesh can be scaled on demand without developers worrying about the infrastructure needed to run their applications. The Mesh service not only takes care of the physical infrastructure, but also detects and handles infrastructure failures, manages service discovery, data-partitioning, no-downtime upgrades, and other features that developers need from an application platform to building highly available and scalable applications. Developers win because they do not have to manage infrastructure, have a simple getting started experience, and can write  applications that automatically scale. Operations and IT managers win because they are billed only for resources they’re using on a per second basis and have simpler deployments.

![Mesh-01][Mesh-01]

Mesh is an application platform for developing cloud-native applications built as microservices that are deployed in containers. Mesh is powered by [Azure Service Fabric]((http://docs.microsoft.com/azure/service-fabric/.md)). Today companies on a path to application modernization build applications consisting of stateless or stateful microservices. Mesh enables developers to build stateful services using either built-in low latency container volume drivers or reliable collections (dictionary, queue) that can be used with any programming mode, or framework.

With Mesh all services are deployed and managed in containers so that organizations can modernize and enhance existing applications, or build new applications using microservices approach. Smaller teams develop a service that focuses on a scenario and independently test, version, deploy, and scale each microservice so that the entire application evolves over time.

## Infrastructure

Mesh consists of clusters of thousands of machines at geo-scale that can span not only Azure zones, but also regions for high availability and reliability. These clusters run applications packed efficiently based on resources required. The applications are orchestrated as load changes or failures occur.  You only care about the health and responsiveness of the containers associated with your applications.  You upload code specifying scale, HA requirements, resource limits and Mesh takes care of reliably running your code and the microbilling for the resources requested.

## Roadmap

In order to make the public preview successful, we need your help. Each private preview release leading up to a public preview, will add more features. The feedback you provide will impact the private releases. All the private previews are free, but will be quota limited. More details will be provided as we roll out each preview.

Here are some of the features you can expect to evaluate and provide feedback on.

- Azure Resource Manager or CLI deployments
- Ability to scale in/out services
- Persistence with volume drivers
- Service Mesh for communication
- Visual Studio integration
- Reliable Collections for statefulness
- Cross-zone deployments for HA

## Private Preview 3 Capabilities

This release is focused on an experience for developing .net core applications using Visual Studio on Windows. The preview update brings support for creating resource applications in Visual Studio, running and debugging them in a local Service Fabric cluster, and publishing the applications to Azure Service Fabric Mesh.

The applications based on Service Fabric resource model will be able to run in Mesh as well as on your local development environment, standalone clusters, and existing Azure clusters. Currently as part of this private preview, this resource application model is available in Azure Service Fabric Mesh and in the Service Fabric SDK 6.3 preview runtime for Windows clients (OneBox).

**Please note that the 6.3 preview cluster is a regular Service Fabric cluster and therefore also support manifest based applications and reliable services. Services and applications built using the 6.3 preview SDK are not supported to run in existing 6.2 clusters.**

Instructions on how to get started using Visual Studio with Azure Service Fabric Mesh are [here](./docs/conceptual-docs/setup-developer-environment-sdk.md)

## Preview Limitations

As you are testing and providing feedback on this Mesh Private Preview please be mindful of the following limitations:

- The max core count per application is limited to 6 (You can deploy 6 containers of 1 core each or 12 containers of 0.5 core each)
- The max core count per container cannot exceed 2.
- The number of parallel applications you have running should be kept to around 5. You'll need to delete your application deployments when you are not actively working with it.

Here is the [Service Fabric Mesh preview EULA](http://aka.ms/seabreezeprevieweula).

## Getting Started

Here is how you can get started:

- Deploy an application to Mesh using Azure CLI [quickstart guide](./docs/conceptual-docs/application-deployment-quickstart.md).

- Create an asp.net core application using Visual Studio and deploy to Mesh []().

- Read about the [Application Model](./docs/conceptual-docs/appmodel-overview.md) and learn how to achieve particular scenarios and deploy examples on Mesh.

## Frequently asked questions and known Issues

[Frequently asked questions and known issues](./docs/conceptual-docs/FAQ-and-KnownIssues.md) with this private preview.

## Feedback

We look forward to hearing your feedback about Mesh. Please use this repo's [Issues](https://github.com/Azure/seabreeze-preview-pr/issues) to inform us of any bugs you come across, or improvements you would like to request.

<!-- Images -->
[Survey]: ./media/Survey.png
[Mesh-01]: ./media/Mesh.png

## Contributing to this project

This project has adopted the
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any
additional questions or comments.
