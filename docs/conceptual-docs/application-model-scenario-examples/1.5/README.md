# An application with one microservice - _Provide configuration settings for the service_

## Overview

This example shows how to provide configuration settings to a microservice. There are two ways to provide configuration settings to the service:

1. Environment Variables:

    The settings are provided as environment variables. Any changes in the settings will restart the container.

2. Config Settings:

    The settings are provided in a JSON settings file mounted inside the container. The changes in the settings does not restart the container unless requested in the upgrade command. This is useful for the workloads that can dyanmically load the settings without needing to be restarted.
  
    The name of the settings file is provided in the environment variable `FABRIC_CONFIG_SETTINGS_FILEPATH`. The file format is a JSON with the following structure.
  
    ```json
    {
      "sections": [
        {
          "name": "myConfigSection-1",
          "settings": [
            {
              "name": "myConfigParam-1-1",
              "value": "myConfigParam-1-1-value"
            }
          ]
        },
        {
          "name": "myConfigSection_2",
          "settings": [
            {
              "name": "myConfigParam-2-1",
              "value": "myConfigParam-2-1-value"
            },
            {
              "name": "myConfigParam-2-2",
              "value": "myConfigParam-2-2-value"
            }
          ]
        }
      ]
    }
    ```

### Characteristics

* Code Packages are packaged as container images
* Containers can communicate with each other using localhost
* Configuration is provided in the environment variable and as a setting files

### Questions / Comments 

## Example

| Format | Target | 
|--------|--------|
|  YAML/JSON | [SF Cluster](#sf-cluster) | 
|  JSON-ARM  | [SeaBreeze](#seabreeze) | 

## Deployment

### SF Cluster
Deploy the following resources to Service Fabric cluster. In the order listed below.

#### 1. Network

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

#### 2. Application

```YAML
  application:
    schemaVersion: 0.0.1
    name: myApp
    description: A simple microservices application that shows how to provide configuration settings for the service.
    services:
      - name: myService
        description: ASP.NET core based web service that showcases basic scenarios for SeaBreeze.
        osType: linux
        codePackages:
          - name: helloworld
            image: seabreeze/sbz-helloworld:1.0-alpine
            endpoints:
              - name: myListener
                port: 8080
            config:
              sections:
                - name: myConfigSection-1
                  settings:
                    - name: myConfigParam-1-1
                      value: myConfigParam-1-1-value
                - name: MYConfigSection_2
                  settings:
                    - name: myConfigParam-2-1
                      value: myConfigParam-2-1-value
                    - name: myConfigParam-2-2
                      value: myConfigParam-2-2-value
            resources:
              requests:
                cpu: 2
                memoryInGB: 2
          - name: helloworld-sidecar
            image: seabreeze/sbz-helloworld-sidecar:1.0-alpine
            environmentVariables:
              - name: pingFrequencyInSeconds
                value: 10
            resources:
              requests:
                cpu: 1
                memoryInGB: 1
        replicaCount: 1
        networkRefs:
          - myNetwork

```

### SeaBreeze
Deploy the following resource template to SeaBreeze RP.

#### RP JSON

```JSON
  {
    "$schema": "http://schema.management.azure.com/schemas/2014-04-01-preview/deploymentTemplate.json",
    "contentVersion": "1.0.0.0",
    "resources": [
      {
        "name": "myApp",
        "type": "Microsoft.ServiceFabric/applications",
        "location": "SouthCentralUS",
        "dependsOn": [
          "Microsoft.ServiceFabric/networks/myNetwork",
          "Microsoft.ServiceFabric/networks/myNetwork"
        ],
        "properties": {
          "schemaVersion": "0.0.1",
          "description": "A simple microservices application that shows how to provide configuration settings for the service.",
          "services": [
            {
              "name": "myService",
              "properties": {
                "description": "ASP.NET core based web service that showcases basic scenarios for SeaBreeze.",
                "osType": "linux",
                "codePackages": [
                  {
                    "name": "helloworld",
                    "image": "seabreeze/sbz-helloworld:1.0-alpine",
                    "endpoints": [
                      {
                        "name": "myListener",
                        "port": "8080"
                      }
                    ],
                    "config": {
                      "sections": [
                        {
                          "name": "myConfigSection-1",
                          "settings": [
                            {
                              "name": "myConfigParam-1-1",
                              "value": "myConfigParam-1-1-value"
                            }
                          ]
                        },
                        {
                          "name": "MYConfigSection_2",
                          "settings": [
                            {
                              "name": "myConfigParam-2-1",
                              "value": "myConfigParam-2-1-value"
                            },
                            {
                              "name": "myConfigParam-2-2",
                              "value": "myConfigParam-2-2-value"
                            }
                          ]
                        }
                      ]
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
                    "environmentVariables": [
                      {
                        "name": "pingFrequencyInSeconds",
                        "value": "10"
                      }
                    ],
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
                  "myNetwork"
                ]
              }
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
        "name": "myApp",
        "type": "Microsoft.ServiceFabric/applications",
        "location": "SouthCentralUS",
        "dependsOn": [
          "Microsoft.ServiceFabric/networks/myNetwork",
          "Microsoft.ServiceFabric/networks/myNetwork"
        ],
        "properties": {
          "schemaVersion": "0.0.1",
          "description": "A simple microservices application that shows how to provide configuration settings for the service.",
          "services": [
            {
              "name": "myService",
              "properties": {
                "description": "ASP.NET core based web service that showcases basic scenarios for SeaBreeze.",
                "osType": "linux",
                "codePackages": [
                  {
                    "name": "helloworld",
                    "image": "seabreeze/sbz-helloworld:1.0-alpine",
                    "endpoints": [
                      {
                        "name": "myListener",
                        "port": "8080"
                      }
                    ],
                    "config": {
                      "sections": [
                        {
                          "name": "myConfigSection-1",
                          "settings": [
                            {
                              "name": "myConfigParam-1-1",
                              "value": "myConfigParam-1-1-value"
                            }
                          ]
                        },
                        {
                          "name": "MYConfigSection_2",
                          "settings": [
                            {
                              "name": "myConfigParam-2-1",
                              "value": "myConfigParam-2-1-value"
                            },
                            {
                              "name": "myConfigParam-2-2",
                              "value": "myConfigParam-2-2-value"
                            }
                          ]
                        }
                      ]
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
                    "environmentVariables": [
                      {
                        "name": "pingFrequencyInSeconds",
                        "value": "10"
                      }
                    ],
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
                  "myNetwork"
                ]
              }
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
                "applicationName": "myApp",
                "serviceName": "myService",
                "endpointName": "myListener"
              }
            ]
          }
        }
      }
    ]
  }

```
