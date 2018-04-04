# Example: Hello World SeaBreeze

This example shows how to deploy an application with one microservice and communicate with it using a public load balanced endpoint.

## Example JSON

[https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.json](https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.json)

## Deployment Steps

### Setup SeaBreeze CLI
SeaBreeze CLI is used to deploy and manage the resources in SeaBreeze. Set it up by following these [instructions](./cli-setup.md). 

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
	az sbz deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/helloworld/sbz_rp.json
  
	```

In a minute or so, your command should return with `"provisioningState": "Succeeded"`. Once it does, get the public IP address by querying for the network resources created in this deployment.

### Deploy the template

Once the application status is returned as `"provisioningState": "Succeeded"`, get the public IP address for the service endpoint, and open it on a browser.

The network resource name for this example is `helloWorldNetwork`, fetch information about it using the following command.

```cli
az sbz network show --resource-group <resourceGroupName> --name helloWorldNetwork
```

Get the `publicIpAddress` property and connect to it using a browser. It should display a web page with a welcome message.