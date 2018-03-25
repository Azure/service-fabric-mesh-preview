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
ms.date: 03/24/2018
ms.author: chackdan
ms.editor: chackdan
---

# SeaBreeze Application

This doc will walk you through how to:
* deploy a sample Application
* check its status
* try out your new application
* Review the applicaiton.json 

To read more about applications and SeaBreeze, head over to the [SeaBreeze Overview](./seabreeze-overview.md)

**Note:** In preview 2, you are restricted to a quota of 6 cores. 



## Set up the SeaBreeze CLI
In order to deploy and manage an application, we will be using Azure CLI (minimum required version is 2.0.24). If you don't currently have Azure CLI set up or need to update it, see [Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest). You can run this quickstart on [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).

1. Open a [CLI prompt](https://docs.microsoft.com/en-us/cli/azure/overview?view=azure-cli-latest) or Bash shell using [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).
2. Remove any previous install of the SeaBreeze CLI module.

	```cli
	az extension remove --name azure-cli-sbz 
	```

3. Install the SeaBreeze CLI module. For the preview, we are providing a .whl file with the CLI module, at public preview we would ship it as a part of the Azure CLI.

	```cli
	az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.4.0-py2.py3-none-any.whl
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
In a few seconds, your command should return with "provisioningState": "Succeeded" 

![AppDepl]
 

## Check application deployment status
At this point, your application has been deployed. You can check to see its status by using the `app show` command. This command is useful, if you wanted to followup on a appliation deployment.

```cli
az sbz app show --resource-group <resourceGroupName> --name <applicationName>
```

## Go to the application

Once the application status is returned as ""provisioningState": "Succeeded", we need the ingress endpoint of the service, so let us query the netwokr resource, so get IP address to the container where the service is deployed, and open it on a browser.

The network resource for our quickstart application is SbzVotingNetwork, so let us fetch its details.

```cli
az sbz network show --resource-group <resourceGroupName> --network-name SbzVotingNetwork
```
The command should now return, with infromation like the screen shot below, copy the IP address from it.
![ingress]

For example, my service end point IP is 13.90.141.214 and I just open the URL - http://13.90.141.214:80 in your favorite browser.

You can now add voting options to the application and vote on it, or delete the voting options.

![votingapp]

## Quick review of the quick start application details

For a detailed review of this quick start application and its source code, go to the [Samples includes in the Repo](https://github.com/Azure/seabreeze-preview-pr/tree/master/samples) folder. 

Let us quickly review the [Application-quickstart.Json](https://seabreezequickstart.blob.core.windows.net/quickstart/application-quickstart.json)

This application has two Services : VotingWeb  and VotingData . They are marked by the red boxes in the picture below.

![appjson]

Let us now review the VotingWeb service. Its code package is in a container called "VotingWeb.Code". The container details are  marked by the red boxes in the picture below.

![servicejson]


## See all the application you have currently deployed to your subscription

You can use the "app list" command to get a list of applications you have deployed to your subscription. 

```cli
az sbz app list -o table
```

## Deleting the application

There are other operations like retrieveing container logs etc,that you can do on the applicaiton. scroll down for those commands. when you are ready to delete the application run the following command. 

```cli
az sbz app delete --resource-group <resourceGroupName> 
```
In order to conserve the limited resources allocated to the preview program, it is encouraged that you do not leave your application running overnight, unless you have a specific need to do so.

## See the application logs

For this preview, we have not enabled the ablity for you to pump the logs, events and preformance counters to azure storage for later diagnositics. That funtionality will be enabled as we progress along towards public preview.

For each codepackage (container) in your service instance, you can check its status as well as the logs coming from the containers in the service. 

1. Check the logs for each container instance in a CGS. In this example, we are going to fetch the logs from the container VotingWeb.Code, which is in the first replica of the service VotingWeb
	
```cli
az sbz container logs --resource-group <myResourceGroup> --application-name <name> --service-name VotingWeb --replica-name 0 --code-package-name VotingWeb.Code
```




<!-- Images -->
[votingapp]: ./media/application-quickstart/voting-app.PNG
[ingress]: ./media/application-quickstart/app-network.PNG
[AppDepl]: ./media/application-quickstart/app-deployment.PNG
[appjson]: ./media/application-quickstart/app-json.PNG
[servicejson]: ./media/application-quickstart/service-json.PNG