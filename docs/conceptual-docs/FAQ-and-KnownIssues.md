---
title: Frequently asked Questions and Known Issues
description: Quick start guide on deploying Container Group Set.
services: Azure SeaBreeze
author: chackdan;
manager: timlt

ms.service: SeaBreeze
ms.topic: overview
ms.assetid:
ms.topic: article
ms.date: 03/22/2018
ms.author: chackdan
ms.editor: chackdan
---

# Frequently asked questions and Known Issues.

### Quota and Cost

**What is the cost of participating in the preview ?**

 There is no charges for deploying applications or containers to Seabreeze Preview. However we expect you to delete the resources you deploy and not leave it running, unless you are actively testing it.

**Is there a quota limit of the # of Cores and RAM ?**

Yes, you are allocated restricted quota for use in the preview.

-  You are allocated a total of 6 Cores and 24 GB RAM.
-  The largest container you can deploy is limited to 2 cores, 8 GB RAM.
-  you can allocate partial cores to your containers. 


**Can I leave my application running overnight ?**

yes, you can, however we expect you to delete the resources you deploy and not leave it running, unless you are actively testing it. This policy may change in the future and we may delete the resources, if they are being misused.


### Features Gaps and Known Issues

**I do not see the current application model supporting a way to encrypt my secrets**
yes,this is a gap in public preview 2. We are working on a secret store service to help with this. 



