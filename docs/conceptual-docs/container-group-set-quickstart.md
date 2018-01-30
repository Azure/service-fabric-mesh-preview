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

## Deploy a Container Group set.

   
1. Open a [CLI prompt](https://docs.microsoft.com/en-us/cli/azure/overview?view=azure-cli-latest)  or Bash Shell using [Cloud shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).
2. Remove any previous install of the SeaBreeze CLI module

	```CLI
	
	az extension remove --name azure-cli-sbz 
	
	```

3. Install the SeaBreeze CLI module. For the preview, we are providing a .whl file with the CLI module, at public preview we would ship it as a part of the Azure CLI.

	```CLI
	
	az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.2.0-py2.py3-none-any.whl
	
	```

4. Login to azure and Set your subscription that has been whitelisted for the preview

	```CLI
	
		az login
		az account set --subscription "13ad2c84-84fa-4798-ad71-e70c07af873f"
	
	```
5. Create a resource group (RG) to deploy the CGS to. you can use can use an existing RG.

	```CLI
	
	az group create --name <myResourceGroup> --location eastus 
	
	```

6. Create a resource group (RG) to deploy the CGS to. you can use can use an existing RG.

	```CLI
	
az group create --name <myResourceGroup> --location eastus 
	
	```

# SeaBreeze CLI Installation

In order to deploy and manage a containger group set, you will be using Azure CLI (minimum required version is 2.0.24). If you don't currently have Azure CLI set up or need to update it, see [Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest).

Alternatively, you could use the Cloud Shell in Azure Portal.

To get access to the SeaBreeze CLI commands, use the following command: 

```bash
az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.3.0-py2.py3-none-any.whl
```

If you have previously installed SeaBreeze CLI extension, use the following command to remove old version first:

```bash
az extension remove --name azure-cli-sbz
```

## Next steps

..

<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG