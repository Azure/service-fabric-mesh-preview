# Scenario: An application with one microservice 

_**No external communication or storage, simple compute**_

* Code Packages are packaged as container images
* Containers can communicate with each other using localhost


## SeaBreeze
Deploy the following JSON to SeaBreeze RP. This is also available in a file at [sbz_rp.json](./sbz_rp.json)



```JSON
  {
    "$schema": "http://schema.management.azure.com/schemas/2014-04-01-preview/deploymentTemplate.json",
    "contentVersion": "1.0.0.0",
    "resources": [
      {
        "name": "helloWorldApp",
        "type": "Microsoft.ServiceFabric/applications",
        "location": "SouthCentralUS",
        "dependsOn": [],
        "properties": {
          "schemaVersion": "0.0.1",
          "description": "Hello world seabreeze!",
          "services": [
            {
              "name": "helloWorldService",
              "properties": {
                "description": "Hello world service.",
                "osType": "linux",
                "codePackages": [
                  {
                    "name": "helloworld",
                    "image": "seabreeze/sbz-helloworld:1.0-alpine",
                    "resources": {
                      "requests": {
                        "cpu": "2",
                        "memoryInGB": "2"
                      }
                    }
                  },
                  {
                    "name": "helloworld-sidecar",
                    "image": "seabreeze/sbz-helloworld-sidecar:1.0-alpine",
                    "resources": {
                      "requests": {
                        "cpu": "1",
                        "memoryInGB": "1"
                      }
                    }
                  }
                ],
                "replicaCount": "1"
              }
            }
          ]
        }
      }
    ]
  }

```

<!-- Files -->

[sbz_rp.json]:./conceptual-docs/application-model-scenario-examples/1.1/sbz_rp.json