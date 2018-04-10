# Monitoring and Diagnostics SeaBreeze 

**THIS IS AN OLD DOC, DEEP is working on a new one**


Monitoring and diagnostics for SeaBreeze is generally catagorized into three main types of diagnostics data:

1. Application logs - these are defined as the logs from your containerized applications, based on how you have instrumented your application (docker logs)
2. Platform container events - events from the SeaBreeze platform relevant to your container operation, currently including container activation, deactivation, termination.
3. Container metrics - resource utilization and performance metrics for your containers (docker stats)

This article discusses the monitoring and diagnostics options for the latest preview version available.

## Container events

Here is a list of current container events exposed in the platform, with a brief description: 

* ContainerActivated: container succesfully created and started
* ContainerDeactivated – container stopped
* ContainerTerminated – container exited with status (could be 'success' or 'error'). The container will be restarted automatically. 

Currently, events can be viewed at a container group set (CGS) instance level. This can be for each instance, or for all instances of a CGS. Here are the Azure CLI commands to view container events. 

```cli
az sbz cgs instance --resource-group <nameOfResourceGroup> --name <nameOfCGS>
```

```cli
az sbz cgs instance --resource-group <nameOfResourceGroup> --name <nameOfCGS> --instance-name <nameOfCGSInstance>
```

## Application logs

You can view your docker logs from your deployed containers, on a per container basis, using the following command:

```cli
az sbz cgs logs --resource-group <nameOfResourceGroup> --name <nameOfCGS>  --instance-name <nameOfCGSInstance> --container-name <nameOfContainer>
```
