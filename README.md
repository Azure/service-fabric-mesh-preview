# Service Fabric SeaBreeze

SeaBreeze is fully managed serverless offering which enables developers to deploy containerized applications without managing any infrastructure, while still being able to use Service Fabric's runtime features and programming models. SeaBreeze is aiming to be the easiest way to run a containerized workload in the cloud, while ensuring production requirements like high availability and scalability. 

![Seabreeze-01][Seabreeze-01]

To learn more about the platform,and the scope of the current private preview refer to the [Service Fabric SeaBreeze overview] (./docs/conceptual-docs/seabreeze-overview.md) doument.

To get started with using the platform, see our [quickstart](./docs/conceptual-docs/application-quickstart.md).

To learn about the SeaBreeze resource management APIs, see [API reference docs](https://github.com/Azure/seabreeze-preview-pr/blob/master/docs/reference-docs/seabreeze-index.md).

We look forward to hearing your feedback about SeaBreeze. Please use this repo's [Issues](https://github.com/Azure/seabreeze-preview-pr/issues) to inform us of any bugs you come across, or improvements you would like to request. 

## SeaBreeze Preview

As you are testing and providing feedback on this SeaBreeze Private Preview please be mindful of the following limitations:

* The max core count per Container Group Set (CGS) - 6 (You can deploy 6 containers of 1 core each or 12 containers of 1/2 core each)
* The max core count per container cannot exceed 2. 
* The number of parallel applications you have running should be kept to around 5. You'll need to delete your application deployments when you are not actively working with it.

Here is the [Service Fabric SeaBreeze preview EULA](http://aka.ms/seabreezeprevieweula).

# Contributing to this project

This project has adopted the
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any
additional questions or comments.

<!-- Images -->

[Seabreeze-01]: ./docs/conceptual-docs/media/overview/SeaBreeze.PNG

[Milestones]: ./media/overview/Milestones.PNG
