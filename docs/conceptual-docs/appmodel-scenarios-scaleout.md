# Example: Visual Objects - Scale

This example shows how to independently scale microservices within an application. In this example, Visual Objects application consists of two microservices; `web` and `worker`. 

The `web` service is an ASP.NET Core application with a web page that shows triangles in the browser. The browser displays one triangle for each instance of the `worker` service. 

The `worker` service moves the triangle at a predefined interval in the space and sends location of the triangle to `web` service. It uses DNS to resolve the address of the `web` service.


## Example JSON

### Base
Linux: [https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.linux.json](https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.linux.json)

Linux: [https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.windows.json](https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.windows.json)

### Scaled Out
Linux: [https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.scaleout.linux.json](https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.scaleout.linux.json)

Linux: [https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.scaleout.windows.json](https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.windows.json)

## Deployment Steps

### Setup Service Fabric Mesh CLI
Service Fabric Mesh CLI is used to deploy and manage Service Fabric Mesh resources of this example. Install it by following these [instructions](./cli-setup.md). 

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

### Deploy the template with one worker service

Create the application and related resources using the following command.

```cli
az mesh deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.linux.json
  
```
In a minute or so, your command should return with `"provisioningState": "Succeeded"`. Once it does, get the public IP address by querying for the network resources created in this deployment.

To deploy, Windows application use[https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.windows.json](https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.base.windows.json) template. Note for Windows, container images are large compared to Linux, so it may take more time than deploying Linux application.

### Obtain public IP address and connect to it

Once the application status is returned as `"provisioningState": "Succeeded"`, get the public IP address for the service endpoint, and open it on a browser.

The network resource name for this example is `visualObjectsNetwork`, fetch information about it using the following command. 

The network resource name for Windows example is `visualObjectsNetworkWindows`.

```cli
az mesh network show --resource-group <resourceGroupName> --name visualObjectsNetwork
```

Get the `publicIpAddress` property and connect to it using a browser. It should display a web page with one triangle moving through the space.

### Scale `worker` service

Scale the `worker` service to three instances using the following command. 

```cli
az mesh deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/visualobjects/stateless/mesh_rp.scaleout.linux.json
  
```

Once the command return with `"provisioningState": "Succeeded"`,  the browser should be displaying a web page with three triangles moving through the space.

## Delete the resources

To conserve the limited resources assigned for the preview program, delete the resources frequently. To delete resources related to this example, delete the resource group in which they were deployed.

```cli
az group delete --resource-group <resourceGroupName> 
```
