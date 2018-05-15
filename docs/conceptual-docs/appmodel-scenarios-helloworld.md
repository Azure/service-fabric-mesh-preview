<<<<<<< HEAD
# Example: Hello World Mesh
=======
# Example: Hello World
>>>>>>> use Service Fabric Mesh name and add scaleout scenario

This example shows how to deploy an application with one service and communicate with it using a public load balanced endpoint. 

The service has two code packages that are part of the same namespace and can communicate with each other using `localhost`.

## Example JSON

Linux: [https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.linux.json](https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.linux.json)

Windows: [https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.windows.json](https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.windows.json)

## Deployment Steps

<<<<<<< HEAD
### Setup Mesh CLI
Mesh CLI is used to deploy and manage the resources in Mesh. Set it up by following these [instructions](./cli-setup.md). 
=======
### Setup Service Fabric Mesh CLI
Service Fabric Mesh CLI is used to deploy and manage Service Fabric Mesh resources of this example. Install it by following these [instructions](./cli-setup.md). 

>>>>>>> use Service Fabric Mesh name and add scaleout scenario

### Log in to Azure

Log in to Azure and set your subscription to the one that has been white-listed for the preview.

```cli
az login
az account set --subscription "<subscriptionName>"
```

### Create resource group
Create a resource group (RG) to deploy this example or you can use an existing resource group and skip this step. The preview is available only in `eastus` location.

```cli
az group create --name <resourceGroupName> --location eastus 
```

### Deploy the template

Create the application and related resources using the following command.

```cli
az sbz deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.linux.json
  
```
In a minute or so, your command should return with `"provisioningState": "Succeeded"`. Once it does, get the public IP address by querying for the network resources created in this deployment.

To deploy, Windows application use[https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.windows.json](https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.windows.json) template. Note for Windows, container images are large compared to Linux, so it may take more time than deploying Linux application.

### Obtain public IP address and connect to it

Once the application status is returned as `"provisioningState": "Succeeded"`, get the public IP address for the service endpoint, and open it on a browser.

The network resource name for this example is `helloWorldNetwork`, fetch information about it using the following command. 

The network resource name for Windows example is `helloWorldNetworkWindows`.

```cli
az sbz network show --resource-group <resourceGroupName> --name helloWorldNetwork
```

Get the `publicIpAddress` property and connect to it using a browser. It should display a web page with a welcome message.

## Delete the resources

To conserve the limited resources assigned for the preview program, delete the resources frequently. To delete resources related to this example, delete the resource group in which they were deployed.

```cli
az group delete --resource-group <resourceGroupName> 
```


