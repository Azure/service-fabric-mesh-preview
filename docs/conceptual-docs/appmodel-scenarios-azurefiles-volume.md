# Container Volume Sample
This sample illustrates the use of volumes in Mesh containers.

The container requests a volume, that is backed by a specific [Azure Files](https://docs.microsoft.com/azure/storage/files/storage-files-introduction) file share, to be mounted to a specific location within the container. The application that runs inside the container writes a text file to this location.

## Example JSON

Linux: [https://seabreezequickstart.blob.core.windows.net/templates/azurefiles-volume/sbz_rp.linux.json](https://seabreezequickstart.blob.core.windows.net/templates/azurefiles-volume/sbz_rp.linux.json)

Windows: [https://seabreezequickstart.blob.core.windows.net/templates/azurefiles-volume/sbz_rp.windows.json](https://seabreezequickstart.blob.core.windows.net/templates/azurefiles-volume/sbz_rp.windows.json)

## Deployment Steps

### Create the Azure Files file share
Follow the instructions in the [Azure Files documentation](https://docs.microsoft.com/en-us/azure/storage/files/storage-how-to-create-file-share) to create a file share for the application to use.

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

### Deploy the template
Create the application and related resources using one of the following commands.

For Linux:

```cli
az mesh deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/azurefiles-volume/sbz_rp.linux.json
```

For Windows:

```cli
az mesh deployment create --resource-group <resourceGroupName> --template-uri https://seabreezequickstart.blob.core.windows.net/templates/azurefiles-volume/sbz_rp.windows.json
```

Follow the prompts to enter the file share name, account name, and account key for the Azure File share that provides the volume. In a minute or so, your command should return with `"provisioningState": "Succeeded"`.

> The password parameter in the template is of `string` type for ease of use. It will be displayed on the screen in clear-text and in the deployment status.

### Verify that the application is able to use the volume
The application creates a file named _data.txt_ in the file share (if it does not exist already). The content of this file is a number that is incremented every 30 seconds by the application. To verify that the example works correctly, open the _data.txt_ file periodically and verify that the number is being updated.

The file may be downloaded using any tool that enables browsing an Azure Files file share. The [Microsoft Azure Storage Explorer](https://azure.microsoft.com/en-us/features/storage-explorer/) is an example of such a tool.
