# Deploy a quickstart application

In this introduction to Sea Breeze we will walk you through;

 * Deploying a sample quickstart application called “SbzVoting” which is a web voting application. The application consists of two services, a web front-end and a storage back-end.
* Check its status once it is deployed
* Try out the application
* Review the application JSON file to see its layout
*	View the container logs for the services deployed in your application
*	Delete the application to free up resources.
 

> In preview 2, you are restricted to a quota of 6 cores. 


## Set up the SeaBreeze CLI

In order to deploy and manage an application, we will be using SeaBreeze CLI. Setup SeaBreeze CLI by following these [instructions](./cli-setup.md). 

## Create the resources

1. Login to Azure and set your subscription to the one that has been white-listed for the preview.

```cli
	az login
	az account set --subscription "<subscriptionName>"
```
2. Create a resource group (RG) to deploy the application to. Alternatively, you can use an existing RG and skip this step. The preview is available only in eastus.

```cli
	az group create --name <resourceGroupName> --location eastus 
```

3. Create your application using the following deployment command: 

```cli
	az sbz deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/quickstart/sbz_rp.linux.json

```
In a few seconds, your command should return with "provisioningState": "Succeeded" . Given below is the output from the command when using [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview). 

![AppDepl]
 

## Check application deployment status
At this point, your application has been deployed. You can check to see its status by using the `app show` command. This command is useful, if you wanted to followup on a application deployment.

The application name for our quickstart application is SbzVoting, so let us fetch its details. 

```cli
az sbz app show --resource-group <resourceGroupName> --name SbzVoting
```

## Go to the application

Once the application status is returned as ""provisioningState": "Succeeded", we need the ingress endpoint of the service, so let us query the network resource, so get IP address to the container where the service is deployed, and open it on a browser.

The network resource for our quickstart application is SbzVotingNetwork, so let us fetch its details.

```cli
az sbz network show --resource-group <resourceGroupName> --name SbzVotingNetwork
```
The command should now return, with information like the screen shot below when running the command in [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).
From the output, copy the IP address .
![ingress]

For example, my service end point IP is 13.90.141.214 and I just open the URL - http://13.90.141.214:80 in your favorite browser.

You can now add voting options to the application and vote on it, or delete the voting options.

![votingapp]

## Quick review of the quick start application details

For a detailed review of this quick start application and its source code, go to the [quick start sample](..\..\samples\src\quickstart) folder. 

Let us quickly review the [deployment JSON](https://seabreezequickstart.blob.core.windows.net/templates/quickstart/sbz_rp.linux.json)

This application has two Services : VotingWeb  and VotingData . They are marked by the red boxes in the picture below.

![appjson]

Let us now review the VotingWeb service. Its code package is in a container called "VotingWeb.Code". The container details are  marked by the red boxes in the picture below.

![servicejson]


## See all the application you have currently deployed to your subscription

You can use the "app list" command to get a list of applications you have deployed to your subscription. 

```cli
az sbz app list -o table
```

## Delete the resources

There are other operations like retrieving container logs etc,that you can do on the application. scroll down for those commands. when you are ready to delete the application and related resources, delete the resource group containing them.

```cli
az group delete --resource-group <resourceGroupName> 
```
In order to conserve the limited resources allocated to the preview program, it is encouraged that you do not leave your resources running overnight, unless you have a specific need to do so.

## See the application logs

For this preview, we have not enabled the ability for you to pump the logs, events and performance counters to azure storage for later diagnostics. That functionality will be enabled as we progress along towards public preview.

For each codepackage (container) in your service instance, you can check its status as well as the logs coming from the containers in the service. 

1. Check the logs for each container instance in a CGS. In this example, we are going to fetch the logs from the container VotingWeb.Code, which is in the first replica of the service VotingWeb
	
```cli
az sbz codepackage logs --resource-group <myResourceGroup> --application-name SbzVoting --service-name VotingWeb --replica-name 0 --code-package-name VotingWeb.Code
```


<!-- Images -->
[votingapp]: ./media/application-quickstart/voting-app.PNG
[ingress]: ./media/application-quickstart/app-network.PNG
[AppDepl]: ./media/application-quickstart/app-deployment.PNG
[appjson]: ./media/application-quickstart/app-json.PNG
[servicejson]: ./media/application-quickstart/service-json.PNG
