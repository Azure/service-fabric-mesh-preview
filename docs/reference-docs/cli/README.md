### sbz

   Summary:
      (PREVIEW) Manage Azure Mesh Resources.

   Description:
### sbz app

   Summary:
      Manage Mesh applications.

   Description:
### sbz app delete

   Summary:
      Delete a Mesh application.

   Description:
   --name -n

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --yes -y

      Required:
         False

      Summary:
         Do not prompt for confirmation.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz app list

   Summary:
      List Mesh applications.

   Description:
   --resource-group -g

      Required:
         False

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz app show

   Summary:
      Get the details of a Mesh application.

   Description:
   --name -n

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz codepackage

   Summary:
      Manage Mesh service replica code packages.

   Description:
### sbz codepackage logs

   Summary:
      Examine the logs for a codepackage.

   Description:
   --app-name --application-name

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --name -n

      Required:
         True

      Summary:
         The name of the code package.

      Description:
   --replica-name

      Required:
         True

      Summary:
         The identity of the service replica.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --service-name

      Required:
         True

      Summary:
         The identity of the service.

      Description:
   --tail

      Required:
         False

      Summary:
         Only show this number of log lines. If not provided, the last
         100 lines are shown.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz deployment

   Summary:
      Manage SeaBreeze deployments.

   Description:
### sbz deployment create

   Summary:
      Create a SeaBreeze application.

   Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --mode

      Required:
         False

      Summary:
      Description:
   --name -n

      Required:
         False

      Summary:
         The deployment name. Default to template file base name.

      Description:
   --no-wait

      Required:
         False

      Summary:
         Do not wait for the long-running operation to finish.

      Description:
   --parameters

      Required:
         False

      Summary:
      Description:
   --template-file

      Required:
         False

      Summary:
         The full file path of creation template.

      Description:
   --template-uri

      Required:
         False

      Summary:
         The full file path of creation template on a http or https
         link.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
   Create a deployment with a template file on the remote.

      az mesh deployment create --resource-group mygroup --template-uri
      https://seabreezequickstart.blob.core.windows.net/templates/qui
      ckstart/sbz_rp.linux.json

   Create a deployment with a template file on local disk.

      az mesh deployment create --resource-group mygroup --template-
      file ./appTemplate.json

### sbz network

   Summary:
      Manage networks.

   Description:
### sbz network delete

   Summary:
      Delete a network.

   Description:
   --name -n

      Required:
         True

      Summary:
         The name of the network.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --yes -y

      Required:
         False

      Summary:
         Do not prompt for confirmation.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz network list

   Summary:
      List networks.

   Description:
   --resource-group -g

      Required:
         False

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz network show

   Summary:
      Get the details of a network.

   Description:
   --name -n

      Required:
         True

      Summary:
         The name of the network.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz service

   Summary:
      Manage SeaBreeze services.

   Description:
### sbz service list

   Summary:
      Gets services of a given application.

   Description:
      Gets the information about all services of a given service of an
      application. The information includes the runtime properties of
      the service instance.

   --app-name --application-name

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz service show

   Summary:
      Get the details of a service.

   Description:
   --app-name --application-name

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --name -n

      Required:
         True

      Summary:
         The name of the service.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz servicereplica

   Summary:
      Manage SeaBreeze service replicas.

   Description:
### sbz servicereplica list

   Summary:
      List the details of service replicas.

   Description:
   --app-name --application-name

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --service-name

      Required:
         True

      Summary:
         The identity of the service.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz servicereplica show

   Summary:
      Gets a specific replica of a given service.

   Description:
      Gets the information about the specified replica of a given
      service of an application. The information includes the runtime
      properties of the replica instance.

   --app-name --application-name

      Required:
         True

      Summary:
         The name of the application.

      Description:
   --name -n

      Required:
         True

      Summary:
         The name of the service replica.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --service-name

      Required:
         True

      Summary:
         The identity of the service.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz volume

   Summary:
      Manage volumes.

   Description:
### sbz volume create

   Summary:
      Create a volume.

   Description:
   --location -l

      Required:
         True

      Summary:
         Location. You can configure the default location using *az
         configure --defaults location=<location>*.

      Description:
   --name -n

      Required:
         True

      Summary:
         The name of the volume.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --template-file

      Required:
         False

      Summary:
         The full file path of creation template.

      Description:
   --template-uri

      Required:
         False

      Summary:
         The full file path of creation template on a http or https
         link.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
   Create a volume with a template file on a remote URL.

      az mesh volume create --location westus --name myvolume
      --resource-group mygroup --template-uri https://mystorage.blob.
      core.windows.net/templates/volumeDescription.json

   Create a volume with a template file on local disk.

      az mesh volume create --location westus --name myvolume
      --resource-group mygroup --template-file
      ./volumeDescription.json

### sbz volume delete

   Summary:
      Delete a volume.

   Description:
   --name -n

      Required:
         True

      Summary:
         The name of the volume.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --yes -y

      Required:
         False

      Summary:
         Do not prompt for confirmation.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz volume list

   Summary:
      List volumes.

   Description:
   --resource-group -g

      Required:
         False

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
### sbz volume show

   Summary:
      Get the details of a volume.

   Description:
   --name -n

      Required:
         True

      Summary:
         The name of the volume.

      Description:
   --resource-group -g

      Required:
         True

      Summary:
         Name of resource group. You can configure the default group
         using *az configure --defaults group=<name>*.

      Description:
   --debug

      Required:
         False

      Summary:
         Increase logging verbosity to show all debug logs.

      Description:
   --help -h

      Required:
         False

      Summary:
         Show this help message and exit.

      Description:
   --output -o

      Required:
         False

      Summary:
         Output format.

      Description:
      Allowed values:
         json, jsonc, table, tsv

      Default:
         json

   --query

      Required:
         False

      Summary:
         JMESPath query string. See http://jmespath.org/ for more
         information and examples.

      Description:
   --verbose

      Required:
         False

      Summary:
         Increase logging verbosity. Use --debug for full debug logs.

      Description:
