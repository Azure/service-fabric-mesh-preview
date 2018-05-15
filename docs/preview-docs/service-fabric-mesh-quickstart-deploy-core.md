---
# Mandatory fields. See more on aka.ms/skyeye/meta.

title: Quickstart - Deploy an existing container to Azure Service Fabric Mesh
description: This quickstart shows you how to deploy an existing container on Service Fabric Mesh.
services: Azure Service Fabric Mesh
keywords: 
author: thraka
ms.author: adegeo
ms.date: 04/11/2018
ms.topic: quickstart
ms.service: service-fabric-mesh
manager: timlt
#Intent: I want to to containerize an app as is and deploy them to Azure. (Windows or Linux) 
---
# Service Fabric Mesh: Deploy a container

Service Fabric Mesh makes it easy to create and manage Docker containers in Azure, without having to provision virtual machines. In this quickstart, you create a container in Azure and expose it to the internet. This operation is completed in a single command. Within just a couple minutes, you'll see this in your browser:

![Hello world app in the browser][sfm-app-browser]

To read more about applications and Service Fabric Mesh, head over to the [Service Fabric Mesh Overview](./service-fabric-mesh-overview.md)

|     |
| --- |
| Service Fabric Mesh is in currently in preview, and only supports the **East US** region. Previews are made available to you on the condition that you agree to the [supplemental terms of use](https://azure.microsoft.com/support/legal/preview-supplemental-terms/). Some aspects of this feature may change prior to general availability (GA). |

If you don't already have an Azure account, [create a free account](https://azure.microsoft.com/free/) before you begin.

[!INCLUDE [cloud-shell-try-it.md](../../includes/cloud-shell-try-it.md)]

You can use the Azure Cloud Shell or a local installation of the Azure CLI to complete this quickstart. If you choose to install and use the CLI locally, this quickstart requires that you're running the Azure CLI version 2.0.30 or later. Run `az --version` to find the version. To install or upgrade to the latest version of the CLI, see [Install Azure CLI 2.0][azure-cli-install].

## Create a resource group

Create a resource group to deploy the application to. Alternatively, you can use an existing resource group and export rg to the name.

```azurecli-interactive
export rg=myResourceGroup
az group create --name $rg --location eastus
```

## Deploy the container


/// code to build quick sample app

docker pull microsoft/aspnetcore
dotnet new web --name meshapp2
cd meshapp2
dotnet publish -o ./publish
code dockerfile

    FROM microsoft/aspnetcore
    
    WORKDIR /app
    
    COPY ./publish .
    
    ENTRYPOINT ["dotnet", "meshapp2.dll"]

docker build -t meshapp-tutorial .
docker run -p 8181:80 meshapp-tutorial

az sbz deployment create --resource-group myResGroup --template-file C:\Users\adegeo\code\meshapp2\template.json --parameters `@template.params.json

az sbz network show --resource-group $rg --name helloWorldNetwork

## Clean up resources

When you are ready to delete the application run the following command, you'll be prompted to confirm deletion enter `y` to confirm the command.

```azurecli-interactive
az sbz app delete -g $rg -n helloWorldApp
```

If you no longer need any of the resources you created in this quickstart, you can execute the [az group delete][az-group-delete] command to remove the resource group and all resources it contains. This command deletes the container deployed to service fabric mesh and all related resources.

```azurecli-interactive
az group delete --name $rg
```

## Next steps

Advance to the next article to learn more about Service Fabric Mesh
> [!div class="nextstepaction"]
> [Next steps button](service-fabric-mesh-overview.md)

<!-- Images -->
[sfm-app-browser]: ./media/service-fabric-mesh-quickstart-containers-01.png

<!-- Links / Internal -->
[az-group-delete]: /cli/azure/group#az_group_delete
[azure-cli-install]: /cli/azure/install-azure-cli