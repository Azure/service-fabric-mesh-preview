# Scenario: An application with one microservice 

_**Use image from private registry**_


Shows how to provision and use a secret resource.

* Code Packages are packaged as container images
* Containers can communicate with each other using localhost
* Rather than using default image repository use custom image repository


| Format | Target | 
|--------|--------|
|  YAML/JSON | [SF Cluster](#sf-cluster) | 
|  JSON-ARM  | [SeaBreeze](#seabreeze) | 

# Deployment
## SF Cluster
Deploy the following resources to Service Fabric cluster. In the order listed below.

### 1. Secrets 

```YAML
  secretStore:
    schemaVersion: 0.0.1
    name: myStore
    secrets:
      - name: imageRegistryPassword
        kind: inline
        value: myPassword

```

### 2. Application

```YAML
  application:
    schemaVersion: 0.0.1
    name: helloWorldApp
    description: Hello world seabreeze! 
    services:
      - name: helloWorldService
        description: Hello world service.
        osType: linux
        codePackages:
          - name: helloworld
            image: seabreeze/sbz-helloworld:1.0-alpine
            imageRegistryCredential:
              server: microsoft
              username: TestUser
              password: "[reference(secret:myStore/imageRegistryPassword)]"
            resources:
              requests:
                cpu: 2
                memoryInGB: 2
  
          - name: helloworld-sidecar
            image: seabreeze/sbz-helloworld-sidecar:1.0-alpine
            resources:
              requests:
                cpu: 1
                memoryInGB: 1
  
        replicaCount: 1

```

## SeaBreeze
Deploy the following resource template to SeaBreeze RP.

### RP JSON

```JSON
  {
    "$schema": "http://schema.management.azure.com/schemas/2014-04-01-preview/deploymentTemplate.json",
    "contentVersion": "1.0.0.0",
    "resources": [
      {
        "name": "myStore",
        "type": "Microsoft.ServiceFabric/secretStores",
        "location": "SouthCentralUS",
        "dependsOn": [],
        "properties": {
          "schemaVersion": "0.0.1",
          "secrets": [
            {
              "name": "imageRegistryPassword",
              "kind": "inline",
              "value": "myPassword"
            }
          ]
        }
      },
      {
        "name": "helloWorldApp",
        "type": "Microsoft.ServiceFabric/applications",
        "location": "SouthCentralUS",
        "dependsOn": [
          "Microsoft.ServiceFabric/secretStores/myStore"
        ],
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
                    "imageRegistryCredential": {
                      "server": "microsoft",
                      "username": "TestUser",
                      "password": "[reference(secret:myStore/imageRegistryPassword)]"
                    },
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
