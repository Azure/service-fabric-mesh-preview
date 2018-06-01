# Monitoring and Diagnostics Mesh 

Monitoring and diagnostics for Mesh is generally catagorized into three main types of diagnostics data:

1. Application logs - these are defined as the logs from your containerized applications, based on how you have instrumented your application (docker logs)
2. Platform events - events from the SeaBreeze platform relevant to your container operation, currently including container activation, deactivation, termination.
3. Container metrics - resource utilization and performance metrics for your containers (docker stats)

This article discusses the monitoring and diagnostics options for the latest preview version available.

## Application logs

You can view your docker logs from your deployed containers, on a per container basis. In the Mesh application model, each container is a code package in your application. To see the associated logs with a code package, use the following command:

```cli
az mesh codepackage logs --resource-group <nameOfResourceGroup> --app-name <nameOfCGS> --service-name <nameOfService> --replica-name <nameOfReplica> --code-package-name <nameOfCodePackage>
```

*Note: currently, replica names are incrementing numbers from 0.*

Here is what this looks like for seeing the logs from the VotingWeb.Code container from the [quickstart](application-deployment-quickstart.md):

```cli
az mesh codepackage logs --resource-group <RG> --app-name SbzVoting --service-name VotingWeb --replica-name 0 --code-package-name VotingWeb.Code
```

## Platform events

Here is a list of current events exposed in the platform, with a brief description: 

* ContainerActivated: container succesfully created and started
* ContainerDeactivated – container stopped
* ContainerTerminated – container exited with status (could be 'success' or 'error'). The container will be restarted automatically. 

Currently, events can be viewed at a servicereplica level. Here is the CLI command to view container events. 

```cli
az mesh servicereplica show <nameOfResourceGroup> --app-name <nameOfCGS> --service-name <nameOfService> --replica-name <nameOfReplica>
```

Here is what this looks like for seeing events for the VotingWeb service deployed in the [quickstart](application-deployment-quickstart.md):

```cli
az mesh servicereplica show --resource-group <RG> --app-name SbzVoting --service-name VotingWeb --replica-name 0 
```

## Metrics

We're still working on enabling these - look for them in a future release!
