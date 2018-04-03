---
title: SeaBreeze CLI setup
description: Guide on setting up the SeaBreeze CLI
services: Azure SeaBreeze
author: linggeng;chackdan
manager: vipulm

ms.service: SeaBreeze
ms.topic: overview
ms.assetid:
ms.topic: article
ms.date: 03/26/2018
ms.author: linggeng;chackdan
ms.editor: linggeng;chackdan
---

# SeaBreeze CLI Setup

SeaBreeze CLI requires Azure CLI version 2.0.30 and above. If you don't currently have Azure CLI set up or need to update it, see [Install Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest).

You can also install and run SeaBreeze CLI on [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).


1. Open a [CLI prompt](https://docs.microsoft.com/en-us/cli/azure/overview?view=azure-cli-latest) or Bash shell using [Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview).

2. Remove any previous install of the SeaBreeze CLI module.

	```cli
	az extension remove --name azure-cli-sbz 
	```

3. Install the SeaBreeze CLI extension module. For the preview, SeaBreeze CLI is written as an extension to Azure CLI, however, at public preview it would ship as a part of the Azure CLI.

	```cli
	az extension add --source https://seabreezepreview.blob.core.windows.net/cli/azure_cli_sbz-0.4.0-py2.py3-none-any.whl
	```
