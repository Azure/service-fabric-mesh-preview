# escape=`
# run with : pushd pkg\Windows\ && docker build -t volumetest:wincore1709 -f VolumeTestApp.Windows.dockerfile . && popd

FROM microsoft/windowsservercore:1709

SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

# Retrieve .NET Core Runtime
ENV DOTNET_VERSION 2.0.9
ENV DOTNET_DOWNLOAD_URL https://dotnetcli.blob.core.windows.net/dotnet/Runtime/$DOTNET_VERSION/dotnet-runtime-$DOTNET_VERSION-win-x64.zip
ENV DOTNET_DOWNLOAD_SHA 4e03072925ca65f350112916eac8f442ee86f84de5fd8643d6db9eb96e2175351fdee0fb8ebed6a508b5ce2a3f73bdd4b7a084adc0c765c5249c019f601179f4

RUN Invoke-WebRequest $Env:DOTNET_DOWNLOAD_URL -OutFile dotnet.zip; `
    if ((Get-FileHash dotnet.zip -Algorithm sha512).Hash -ne $Env:DOTNET_DOWNLOAD_SHA) { `
        Write-Host 'CHECKSUM VERIFICATION FAILED!'; `
        exit 1; `
    }; `
    `
    Expand-Archive dotnet.zip -DestinationPath dotnet; `
    Remove-Item -Force dotnet.zip

# In order to set system PATH, ContainerAdministrator must be used
USER ContainerAdministrator
RUN setx /M PATH $($Env:PATH + ';C:\Program Files\dotnet')
USER ContainerUser

# Configure Kestrel web server to bind to port 80 when present
ENV ASPNETCORE_URLS=http://+:80 `
    # Enable detection of running in a container
    DOTNET_RUNNING_IN_CONTAINER=true

ADD bin/ /VolumeTest/Code

ENTRYPOINT ["/VolumeTest/Code/VolumeTestApp.exe"]
