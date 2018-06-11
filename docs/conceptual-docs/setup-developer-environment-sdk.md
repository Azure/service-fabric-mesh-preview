# Setup your development environment to build Service Fabric Mesh applications

Azure Service Fabric applications built using the resource model, can be deployed to any Service Fabric cluster, as well as Azure Service Fabric Mesh.

To build and run Azure Service Fabric applications using the resource model, on your Windows development machine, install the Service Fabric runtime, SDK, and tools.

**You will be installing a preview version of the Service Fabric runtime, version 6.3. This means that you should not do production development, nor attempt to deploy to a production Service Fabric cluster, unless you revert to a supported runtime.**

## Supported operating system versions

The following operating system versions are supported for development:

* Windows 10 (Enterprise, Professional, or Education)
* Windows Server 2016

## Enable Hyper-V

Hyper-V must be enabled for you to create Service Fabric applications.

### Windows 10

Open PowerShell as an administrator and run the following command:

```powershell
Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Hyper-V -All
```

Restart your computer. For more information about how to enable Hyper-V, see [Install Hyper-V on Windows 10](https://docs.microsoft.com/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v).

### Windows Server 2016

Open PowerShell as an administrator and run the following command:

```powershell
Install-WindowsFeature -Name Hyper-V -IncludeManagementTools
```

Restart your computer. For more information about how to enable Hyper-V, see [Install the Hyper-V role on Windows Server 2016](https://docs.microsoft.com/windows-server/virtualization/hyper-v/get-started/install-the-hyper-v-role-on-windows-server).

## Visual Studio

Visual Studio 2017 is required to deploy Service Fabric Applications. [Install version 15.6.0][download-visual-studio] or greater and enable the following workloads:

* ASP.NET and web development
* Azure Development

## Docker

Install Docker to support the containerized Service Fabric applications used by Service Fabric Mesh.

### Windows 10

Download and install the latest version of [Docker Community Edition for Windows][download-docker]. 

During the installation, select **Use Windows containers instead of Linux containers** when asked. You'll need to then log off and log back in. After logging back in, if you did not previously enable Hyper-V, you may be prompted to enable Hyper-V. You must enable Hyper-V and then restart your computer.

After your computer has restarted, Docker will prompt you to enable the **Containers** feature, enable it and restart your computer.

### Windows Server 2016

Use the following PowerShell commands to install Docker. For more information, see [Docker Enterprise Edition for Windows Server][download-docker-server].

```powershell
Install-Module DockerMsftProvider -Force
Install-Package Docker -ProviderName DockerMsftProvider -Force
Install-WindowsFeature Containers
```

Restart your computer.

## SDK and tools

Install the Service Fabric runtime, SDKs, and tools. The different packages will have to be installed in the order outlined below.

1. Download the [Service Fabric Runtime][download-runtime]. Then run it with the **/AcceptEULA** flag from an elevated command line, e.g. c:\users\<you>\downloads\MicrosoftServiceFabric.6.3.116.9494.exe /AcceptEULA
2. Install the [Service Fabric SDK][download-sdk].
3. Install the [Service Fabric Mesh SDK][download-sdkmesh].
4. Install the [Visual Studio Service Fabric Tools (preview)][download-tools].

## Build a cluster

For the best debugging performance when you create and run Service Fabric applications, we recommend creating a single-node local development cluster. This cluster must be running whenever you deploy or debug a Service Fabric Mesh project.

Docker **must** be running before you can build a cluster. Test that Docker is running by opening a terminal window and running `docker ps` to see if an error occurs. If the response does not indicate an error, Docker is running and you're ready to build a cluster.

After you install the runtime, SDKs and Visual Studio tools, create a development cluster. Open a **new**, **elevated**, PowerShell window and run the following PowerShell commands:

```powershell
. "C:\Program Files\Microsoft SDKs\Service Fabric\ClusterSetup\DevClusterSetup.ps1" -CreateOneNodeCluster -UseMachineName
```

You're now ready to create Service Fabric Mesh applications!

## Next steps

Read through the [Create a .NET Core app to Service Fabric Mesh](tutorial-create-dotnetcore.md) tutorial.
Check the [FAQ and known issues document](FAQ-and-KnownIssues.md)

[download-docker]: https://store.docker.com/editions/community/docker-ce-desktop-windows
[download-docker-server]: https://docs.docker.com/install/windows/docker-ee/
[download-runtime]: http://aka.ms/sfruntime
[download-sdk]: http://aka.ms/sfsdk
[download-sdkmesh]: http://aka.ms/sfmeshsdk
[download-tools]: https://aka.ms/sfvstools
[download-visual-studio]: https://www.visualstudio.com/downloads/