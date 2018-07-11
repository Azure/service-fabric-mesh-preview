# Azure Service Fabric Mesh CLI Setup

Azure Service Fabric Mesh CLI requires Azure CLI version 2.0.30 and above. If you don't currently have Azure CLI set up or need to update it, see [Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest).

You can also install and run Azure Service Fabric Mesh CLI on [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).


1. Open a [CLI prompt](https://docs.microsoft.com/en-us/cli/azure/overview?view=azure-cli-latest) or Bash shell using [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).

2. Remove any previous install of the Azure Service Fabric Mesh CLI module.

Check if the mesh extension is already installed. WIth following command, you can get a list of all installed extensions:
```cli
az extension list
```

If the *mesh* extension is already installed, you will get following result
```cli
[
  . . .
  {
    "extensionType": "whl",
    "name": "mesh",
    "version": "?.?.?"
  }
  . . .
]
```
To remove installed *mesh* extension use following command:

```cli
az extension remove --name mesh
```

3. Install the Azure Service Fabric Mesh CLI extension module. For the preview, Azure Service Fabric Mesh CLI is written as an extension to Azure CLI, however, at public preview it would ship as a part of the Azure CLI.

```cli
az extension add --source https://meshcli.blob.core.windows.net/cli/mesh-0.8.0-py2.py3-none-any.whl
```
