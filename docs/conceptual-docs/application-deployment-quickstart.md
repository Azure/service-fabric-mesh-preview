---
title: Container group set quick start guide
description: Quick start guide on deploying Container Group Set.
services: Azure SeaBreeze
author: chackdan;dkkapur
manager: timlt

ms.service: SeaBreeze
ms.topic: overview
ms.assetid:
ms.topic: article
ms.date: 03/22/2018
ms.author: chackdan
ms.editor: chackdan
---

# SeaBreeze Application

This doc will walk you through how to:
* deploy an Application
* check its status
* check for service logs

To read more about applications and SeaBreeze, head over to the [SeaBreeze Overview](./seabreeze-overview.md)

**Note:** In preview 2, you are restricted to a quota of 6 cores. 



## Set up the SeaBreeze CLI
In order to deploy and manage an application, we will be using Azure CLI (minimum required version is 2.0.24). If you don't currently have Azure CLI set up or need to update it, see [Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest).

1. Open a [CLI prompt](https://docs.microsoft.com/en-us/cli/azure/overview?view=azure-cli-latest) or Bash shell using [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).
2. Remove any previous install of the SeaBreeze CLI module.

	```cli
	az extension remove --name azure-cli-sbz 
	```

3. Install the SeaBreeze CLI module. For the preview, we are providing a .whl file with the CLI module, at public preview we would ship it as a part of the Azure CLI.

	```cli
	az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.3.0-py2.py3-none-any.whl
	```

## Create the application Resource

1. Login to Azure and set your subscription to the one that has been white-listed for the preview.

	```cli
	az login
	az account set --subscription "<subscriptionName>"
	```
2. Create a resource group (RG) to deploy the application to. Alternatively, you can use an existing RG and skip this step. The preview is available only in eastus.

	```cli
	az group create --name <resourceGroupName> --location eastus 
	```

3. Create your application using the following command:

	```cli
	az sbz app create --location eastus --resource-group <resourceGroupName> --name <cgsName> --template-uri https://seabreezequickstart.blob.core.windows.net/quickstart/application-quickstart.json
	```

For a detailed review of what this quick start application does, go to <link to the detail doc>

## Check application deployment status
At this point, your app has been deployed. You can check to see its status by using the `app show` command. 

```cli
az sbz app show --resource-group <resourceGroupName> --name <applicationName>
```

## Go to the application

once the application status is returned as "Deployed", copy the IP address you see for the service, and open it on a browser.

<to do - insert picture>

For example, my service end point IP is 23.99.95.109 and I just open the URL - http://23.99.95.104:80

<to do - insert picture>


## Quick review of the quick start application details

## See application logs

For each codepackage (container) in your service instance, you can check its status as well as the logs coming from the containers in the service. 

1. Check status for a CGS instance
	
	```cli
	az sbz cgs instance --resource-group <resourceGroupName> --name <cgsName> --instance-name <instanceName>
	```

2. Check the logs for each container instance in a CGS

	```cli
	az sbz cgs logs --resource-group <resourceGroupName> --name <cgsName> --instance-name <instanceName> --container-name <containerName>
	```

	If you do not know the `containerName`, use the `az sbz cgs show` (as used above) to display this and other relevant information about your CGS.

## Remove the CGS
To delete the CGS, use the `cgs delete` command. 

```cli
az sbz cgs delete --resource-group <resourceGroupName> --name <cgsName>
```


..

<!-- Images -->
[SeaBreeze-01]: ./media/overview/SeaBreeze.PNG
[Milestones]: ./media/overview/Milestones.PNG
