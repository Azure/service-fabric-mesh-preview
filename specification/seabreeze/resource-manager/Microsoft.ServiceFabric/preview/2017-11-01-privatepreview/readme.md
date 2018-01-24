# Service Fabric SeaBreeze REST APIs

> see https://aka.ms/autorest

[Service Fabric](http://aka.ms/ServiceFabric) is a distributed systems platform that makes it easy to package, deploy, and manage scalable and reliable micro-services. 

Service Fabric SeaBreeze provides serverless environment for running Service Fabric applications and containers with usage based billing.

This folder provides the Swagger specification for Service Fabric SeaBreeze APIs.

## Configuration
Following are the settings for using this specification with [AutoRest](https://aka.ms/autorest) tool to validation and optionally generate SDK.

### Azure Validator Suppressions
Suppressed Rule | Reason
----------------|--------
R3026 TrackedResourcePatchOperation | The patch operation is not implemented in the preview APIs.
R3010 TrackedResourceListByImmediateParent | Containergroupset 'instances' is not a tracked resource.
R3018 EnumInsteadOfBoolean | AzureFileVolume and VolumeMount should match the definition of ACI container group. 
OV108 Example Validations | There are open issues (bugs) in the validator affecting some of the examples and since there is no way to selectively disable the validation for a particular example or paths, all of the example validation is being turned off.
OV109 Example Validations | There are open issues (bugs) in the validator affecting some of the examples and since there is no way to selectively disable the validation for a particular example or paths, all of the example validation is being turned off.



```yaml
model-validator: true 
semantic-validator: true
azure-validator: true
directive:
    suppress:
        - R3026
        - R3010
        - R3018
        - OAV108
        - OAV109

```
