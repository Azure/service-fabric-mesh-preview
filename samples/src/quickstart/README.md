# Service Fabric "Mesh" Quickstart application
This folder contains an application, whcih you can use to quickly get a sense of the base capabilities of Service Fabric "Mesh".

The application lets you add voting options and vote. It consists of two ASP.NET Core 2.0 services. One acts as the front-end and serves a SPA and exposes a web api for the SPA.
The other service acts as the backend data service, and exposes a WebAPI to crete, update and delete the individual votes. The backend service stores the voting in memory and it is not persisted.

The ARM template is avialable in this repository. We've also hosted it in a storage account so you can reference it directly from Azure Cloud Shell.

# Getting Started
To run the quick start do the following:
1.  Deploy using Azure CLI or PowerShell
1.  Browse to the web site...

## Azure CLI Deployment
1. Open https://shell.azure.com and choose bash

### add the module and set subscription 
1. az extension remove --name azure-cli-sbz
1. az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.4.0-py2.py3-none-any.whl
1. az account set --subscription "{your subscript}"

### Create a Resource Group
1. az group create --name SbzVotingRG --location eastus

### Create an application
1. az mesh app create --resource-group SbzVotingRG --template-uri https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.linux.json

### Check Status
1. az mesh app show --resource-group SbzVotingRG --name SbzVoting

### Get the public IP for the application
1. az mesh network show --resource-group SbzVotingRG --name SbzVotingNetwork | grep publicIP

### Get the list of all SeaBreeze applications in the subscription in a table format
1. az mesh app list -o table

### Delete the application
1. az mesh app delete --resource-group SbzVotingRG --name SbzVoting

### Delete the network
1. az mesh network delete --resource-group SbzVotingRG --name SbzVotingNetwork

### Delete the resource group
1. az group delete --name SbzVotingRG --location eastus

## Use PowerShell
There is currently no Mesh PowerShell modules available, the below is doing an ARM deployment based on the template.

1. Open https://shell.azure.com and choose PowerShell or Login-AzureRmAccount if not using Azure Cloud Shell
1. Set-AzureRmContext -SubscriptionId "Subscription-Id"
1. New-AzureRmResourceGroup -Name SbzVotingApp -Location eastus
1. New-AzureRmResourceGroupDeployment -Name DefaultDeployment -ResourceGroupName SbzVotingApp -TemplateUri https://seabreezequickstart.blob.core.windows.net/quickstart/application-quickstart.json
1. $network = Get-AzureRmResource -ResourceGroupName SbzVotingApp -ResourceName SbzVotingNetwork -ResourceType Microsoft.ServiceFabric/networks
1. $network.Properties.ingressConfig.publicIPAddress

### To delete the application
1. Remove-AzureRmResourceGroup -Name SbzVotingApp
