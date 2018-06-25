# Example: OMS Logging - WIP

We will use the Log2OMS client found here: https://github.com/yangl900/log2oms.

This will be a sidecar that will watch files on Azure Files, and will use 4 environment variables.

* `LOG2OMS_WORKSPACE_ID` This is the workspace ID of Log Analytics.
* `LOG2OMS_WORKSPACE_SECRET` This is the secret of your workspace, you can find it from "Advanced Settings" in Azure portal.
* `LOG2OMS_LOG_FILE` This is the log file to tail and upload. Right now only support 1 file, in nginx case, this will be `access.log`
* `LOG2OMS_LOG_TYPE` This is the table you want logs upload to. Note that LogAnalytics will add a postfix `_CL` to this name. so if we have `nginx` here, in LogAnalytics the table will be `nginx_CL`.

We will have a sample app that will emit a file, and the sidecar log2oms will push the file to Log Analytics.

## TODOs

* Check into Linux OMS Agent (built on image or sidecar)
* Check into Windows OMS Agent (built on image or sidecar)
* Check if sidecar can handle multiple files?

# Set up OMS Portal

We are going to borrow some concepts for setting up the OMS workspace.  We will want to get through the step of setting up the workspace and obtaining the workspace and key. 

Linux:
* https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-quick-collect-linux-computer

Windows:
* https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-quick-collect-windows-computer

# How to use it
## Sourced from Log2OMS

https://github.com/yangl900/log2oms

## Sidecar

The docker image is published at https://hub.docker.com/r/yangl/log2oms/

The best way to use log2oms is by adopting the "[sidecar](https://docs.microsoft.com/en-us/azure/architecture/patterns/sidecar)" pattern. Having log2oms container (image `yangl/log2oms`) run as a "sidecar" of your app container, and use a shared volume to read the app logs and uplaod to log2oms.

Take a nginx web server as example, you simply run `yangl/log2oms` as another container and shares the nginx /var/log/nginx volume. log2oms will tail the nginx logs and upload to Log Analytics automatically.

```
  +-----------------------------+
  |              |              |
  |    NGINX     |     log2oms  |
  |              |              |
  +-----------------------------+
  |        (shared volume)      |
  |        /var/log/nginx       |
  +-----------------------------+
```

The log2oms container requires only 4 environment variables to run:

* `LOG2OMS_WORKSPACE_ID` This is the workspace ID of Log Analytics.
* `LOG2OMS_WORKSPACE_SECRET` This is the secret of your workspace, you can find it from "Advanced Settings" in Azure portal.
* `LOG2OMS_LOG_FILE` This is the log file to tail and upload. Right now only support 1 file, in nginx case, this will be `access.log`
* `LOG2OMS_LOG_TYPE` This is the table you want logs upload to. Note that LogAnalytics will add a postfix `_CL` to this name. so if we have `nginx` here, in LogAnalytics the table will be `nginx_CL`.

And that's it. No changes needed from app container.

More flags:
* `LOG2OMS_METADATA_*` This is an environment variable prefix for log metadata. The metadata will be sent to Log Analytics for every log message. This is useful if you have multiple replicas sending logs and want to differentiate them. For example, set `LOG2OMS_METADATA_Location=WestUS` and `LOG2OMS_METADATA_Role=Frontend`, logs in Analytics will have 2 more columns `Location` and `Role`. 

This example shows how to independently scale microservices within an application. In this example, Visual Objects application consists of two microservices; `web` and `worker`. 

The `web` service is an ASP.NET Core application with a web page that shows triangles in the browser. The browser displays one triangle for each instance of the `worker` service. 

The `worker` service moves the triangle at a predefined interval in the space and sends location of the triangle to `web` service. It uses DNS to resolve the address of the `web` service.

## Building locally
This assumes that docker is in Linux containers mode, and that we have logged into ACR
* https://docs.microsoft.com/en-us/azure/container-registry/container-registry-get-started-azure-cli
### Build the Emitter Image 

Make sure we're in the directory for the sample app to emit a log file:

`docker build -t <acr>.azurecr.io/log-emitter:alpine .`

### Build the Log2OMS image

We can simply retag it as well.

`docker build -t <acr>.azurecr.io/log2oms:alpine-test .`

## Push image to ACR

### Push Log2OMS Image
`Docker push <acr>.azurecr.io/log2oms:alpine-test`

### Push Emitter Image
`Docker push <acr>.azurecr.io/log-emitter:alpine`

## Deployment
### Modify Deployment json file
This should be here: 
`.\samples\templates\monitoring\OMS-sidecar-test\deployment-linux.json`

![json-01][json-01]
![json-02][json-02]

We will want to set the environment variables to reflect the OMS workspace.
![json-03-environment-variables][json-03-environment-variables]

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

### Create A File Share (1 time)
Create a file share in the resource group.  This will be a common share for the emitter and the log2oms sidecar.

#### Create a Storage Account

```cli
az storage account create -n MyStorageAccount -g MyResourceGroup -l eastus --sku Standard_LRS
```

Alternatively, we can use the portal to create the storage account too:
![storage-account-creation][storage-account-creation]

#### Retrive Key for Storage Account
```cli
az storage account keys list -g MyResourceGroup --account-name MyStorageAccount
```

We can also verify storage account keys in the portal:
![storage-account-keys][storage-account-keys]


#### Create a File Share
```cli
az storage share create --name myTestShare --account-key <account-key> --account-name MyStorageAccount
```

We can also create a file share in the portal:
![file-share-creation][file-share-creation]

### Deploy using a file

Please be sure to check the path for the deployment file.

```cli
az mesh deployment create --resource-group MyResourceGroup --template-file .\samples\templates\monitoring\OMS-sidecar-test\deployment-linux.json
```

This will prompt for `ACR credentials`:

![azure-container-registry-keys][azure-container-registry-keys]

And also for `Storage Account` and `File Share` keys:
![deployment-parameters][deployment-parameters]

### Verify deployment
```cli 
az mesh code-package-log get -g MyResourceGroup --app-name omsApp --service-name omsService --replica-name 0 --code-package-name omsCode
```

Note that the `replica-name` is ordinal indexed.  We are pulling the `app-name`, `service-name`, and the `code-package-name` from the deployment.json.

![oms-mesh-verify-deployment][oms-mesh-verify-deployment]

We can also check in the OMS portal.  Let the sidecar run a few minutes and Log Analytics should pick up the results (assuming that all the keys are set up too!).

We can use this query in the portal for verification:
```
updates_CL | take 10
```

![oms-portal-verify-deployment][oms-portal-verify-deployment]

## Delete the resources

To conserve the limited resources assigned for the preview program, delete the resources frequently. To delete resources related to this example, delete the resource group in which they were deployed.

```cli
az group delete --resource-group <resourceGroupName> 
```

<!-- Images -->
[json-01]: ./media/appmodel-scenarios-oms-wip/json-01.png
[json-02]: ./media/appmodel-scenarios-oms-wip/json-02.png
[json-03-environment-variables]: ./media/appmodel-scenarios-oms-wip/json-03-environment-variables.png
[storage-account-creation]: ./media/appmodel-scenarios-oms-wip/storage-account-creation.png
[storage-account-keys]: ./media/appmodel-scenarios-oms-wip/storage-account-keys.png
[file-share-creation]: ./media/appmodel-scenarios-oms-wip/file-share-creation.png
[azure-container-registry-keys]: ./media/appmodel-scenarios-oms-wip/azure-container-registry-keys.png
[deployment-parameters]: ./media/appmodel-scenarios-oms-wip/deployment-parameters.png
[oms-mesh-verify-deployment]: ./media/appmodel-scenarios-oms-wip/oms-mesh-verify-deployment.png
[oms-portal-verify-deployment]: ./media/appmodel-scenarios-oms-wip/oms-portal-verify-deployment.png
