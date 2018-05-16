# Example: Hello World Mesh

This example shows how to deploy an application that uses private container image registry. 

## Example JSON

[https://seabreezequickstart.blob.core.windows.net/templates/private-registry/sbz_rp.linux.json](https://seabreezequickstart.blob.core.windows.net/templates/private-registry/sbz_rp.linux.json)

## Deployment Steps

### Setup Service Fabric Mesh CLI
Service Fabric Mesh CLI is used to deploy and manage Service Fabric Mesh resources of this example. Install it by following these [instructions](./cli-setup.md). 

### Log in to Azure

Log in to Azure and set your subscription to the one that has been white-listed for the preview.

```cli
az login
az account set --subscription "<subscriptionName>"
```
### Create a container registry and push image to it
Create Azure Container Registry by following [this](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-get-started-azure-cli) guide. Perform the steps up to ["List container images"](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-get-started-azure-cli#list-container-images) step. At this time, `aci-helloworld:v1` should be present in this private container registry.

### Retrieve credentials for the registry
In order to deploy a container instance from the registry that was created, credentials must be provided during the deployment. The production scenarios should use a [service principal for container registry access](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-auth-service-principal), but to keep this quickstart brief, enable the admin user on your registry with the following command:

```cli
az acr update --name <acrName> --admin-enabled true
```
Once admin access is enabled, get the registry server name, user name, and password using the following commands.

```cli
az acr list --resource-group <resourceGroupName> --query "[].{acrLoginServer:loginServer}" --output table
az acr credential show --name <acrName> --query username
az acr credential show --name <acrName> --query "passwords[0].value"
```

### Deploy the template

Create the application and related resources using the following command and provide the credentials from the previous step. 

> The password parameter in the template is of `string` type for ease of use. It will be displayed on the screen in clear-text and in the deployment status.


```cli
az mesh deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/private-registry/sbz_rp.linux.json
  
```

In a minute or so, your command should return with `"provisioningState": "Succeeded"`. Once it does, get the public IP address by querying for the network resources created in this deployment.

### Obtain public IP address and connect to it


The network resource name for this example is `privateRegistryExampleNetwork`, fetch information about it using the following command.

```cli
az mesh network show --resource-group <resourceGroupName> --name privateRegistryExampleNetwork
```

Get the `publicIpAddress` property and connect to it using a browser. It should display a web page with a welcome message.

## Delete the resources

To conserve the limited resources assigned for the preview program, delete the resources frequently. To delete resources related to this example, delete the resource group in which they were deployed.

```cli
az group delete --resource-group <resourceGroupName> 
```
