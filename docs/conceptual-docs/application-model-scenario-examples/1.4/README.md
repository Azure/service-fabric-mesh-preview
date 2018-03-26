# Scenario: An application with one microservice 

_**Communicate with service using public IP securely*_

Shows how to receive external traffic to a microservice endpoint securely.

* Code Packages are packaged as container images
* Containers can communicate with each other using localhost
* Rather than using default image repository use custom image repository
* Application has its own isolated network
* Create a load balanced TCP port and forward traffic to an endpoint of a microservice

## Questions / Comments 
  - What is the policy for the forwarding the traffic to different instances of the microservice
  - Is there an idle timeout, if so how to configure that?
  - How do I provision certificate resource?


| Format | Target | 
|--------|--------|
|  YAML/JSON | [SF Cluster](#sf-cluster) | 
|  JSON-ARM  | [SeaBreeze](#seabreeze) | 

# Deployment
## SF Cluster
Deploy the following resources to Service Fabric cluster. In the order listed below.

### 1. Secret

```YAML
  secretStore:
    schemaVersion: 0.0.1
    name: myStore
    secrets:
      - name: imageRegistryPassword
        kind: inline
        value: myPassword

```

### 3. Network

```YAML
  network:
    schemaVersion: 0.0.1
    name: myNetwork
    addressPrefix: 10.0.0.4/22
    ingressConfig:
      layer4:
        - publicPort: 8080
          applicationName: myapp
          serviceName: myservice
          endpointName: helloWorldListener

```

### 3. Application

```YAML
  ## Communicate with the service using public IP securely ##
  application:
    schemaVersion: 0.0.1
    name: myapp
    description: Hello world seabreeze! 
    services:
      - name: myService
        description: Hello world service.
        osType: linux
        codePackages:
          - name: helloworld
            image: seabreeze/sbz-helloworld:1.0-alpine
            imageRegistryCredential:
              server: microsoft
              username: TestUser
              password: "[reference(secret:myStore/imageRegistryPassword)]"
            endpoints:
              - name: helloWorldListener
                port: 8080
            certificateRef:
              - name: mycert
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
        networkRefs:
          - mynetwork

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
        "name": "myNetwork",
        "type": "Microsoft.ServiceFabric/networks",
        "location": "SouthCentralUS",
        "dependsOn": [],
        "properties": {
          "schemaVersion": "0.0.1",
          "addressPrefix": "10.0.0.4/22",
          "ingressConfig": {
            "layer4": [
              {
                "publicPort": "8080",
                "applicationName": "myapp",
                "serviceName": "myservice",
                "endpointName": "helloWorldListener"
              }
            ]
          }
        }
      },
      {
        "name": "myapp",
        "type": "Microsoft.ServiceFabric/applications",
        "location": "SouthCentralUS",
        "dependsOn": [
          "Microsoft.ServiceFabric/networks/myNetwork",
          "Microsoft.ServiceFabric/secretStores/myStore"
        ],
        "properties": {
          "schemaVersion": "0.0.1",
          "description": "Hello world seabreeze!",
          "services": [
            {
              "name": "myService",
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
                    "endpoints": [
                      {
                        "name": "helloWorldListener",
                        "port": "8080"
                      }
                    ],
                    "certificateRef": [
                      {
                        "name": "mycert"
                      }
                    ],
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
                "replicaCount": "1",
                "networkRefs": [
                  "mynetwork"
                ]
              }
            }
          ]
        }
      }
    ]
  }

```
