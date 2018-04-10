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
R2020 RequiredPropertiesMissingInResourceModel | Service is a proxy resource that is managed (created and updated) by including it in the application resource. The name is required for RP to manager those resources. The name is readOnly in the default resource schema so it is not serialized on the wire by AutoRest generated libraries. This is a bug on our RP and should be fixed.
R3018 EnumInsteadOfBoolean | The `readOnly` boolean schema is part of Azure Resource Manager common schema.
R3026 TrackedResourcePatchOperation | The patch operation is not implemented in the preview APIs.
R3026 TrackedResourceListByImmediateParent | There are operations to list the tracked resources by parent. This seems like a issue in the validator. 
OV108 Example Validations | There are open issues (bugs) in the validator affecting some of the examples and since there is no way to selectively disable the validation for a particular example or paths, all of the example validation is being turned off.
OV109 Example Validations | There are open issues (bugs) in the validator affecting some of the examples and since there is no way to selectively disable the validation for a particular example or paths, all of the example validation is being turned off.



```yaml
openapi-type: arm

csharp:
  azure-arm: true
  license-header: MICROSOFT_MIT_NO_VERSION


model-validator: true 
semantic-validator: true
azure-validator: true
directive:
    suppress:
        - R3010
        - R3026
        - R3018
        - R2020
        - OAV108
        - OAV109
```
