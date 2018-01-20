# SeaBreeze CLI Installation

Install Azure CLI if not, choose according to your OS type:
[Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest).

The minimum version of Azure CLI is 2.0.24.

You could alternatively use Cloud Shell. 

```bash
az extension remove --name azure-cli-sbz 
az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.2.0-py2.py3-none-any.whl
```

# Contributing

This project has adopted the
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any
additional questions or comments.