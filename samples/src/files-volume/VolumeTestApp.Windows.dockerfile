# escape=`
# run with : pushd pkg\Windows\ && docker build -t volumetest:sac2016 -f VolumeTestApp.Windows.dockerfile . && popd

# Installer image
FROM microsoft/windowsservercore:ltsc2016 AS installer-env

SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

# Retrieve .NET Core Runtime
ENV DOTNET_VERSION 2.1.5

RUN Invoke-WebRequest -OutFile dotnet.zip https://dotnetcli.blob.core.windows.net/dotnet/Runtime/$Env:DOTNET_VERSION/dotnet-runtime-$Env:DOTNET_VERSION-win-x64.zip; `
    $dotnet_sha512 = 'aa7145201f1ed0689ff6abeb53b9c64c1efa1420dee7e5cc916168fd2479e252ed56b2492221f4038edbc73056accd9d4a46ec469155f2bdf0fc71bd909bd220'; `
    if ((Get-FileHash dotnet.zip -Algorithm sha512).Hash -ne $dotnet_sha512) { `
        Write-Host 'CHECKSUM VERIFICATION FAILED!'; `
        exit 1; `
    }; `
    `
    Expand-Archive dotnet.zip -DestinationPath dotnet; `
    Remove-Item -Force dotnet.zip

# Runtime image
FROM microsoft/nanoserver:sac2016

COPY --from=installer-env ["dotnet", "C:\\Program Files\\dotnet"]

RUN setx /M PATH "%PATH%;C:\\Program Files\\dotnet"

# Configure Kestrel web server to bind to port 80 when present
ENV ASPNETCORE_URLS=http://+:80 `
    # Enable detection of running in a container
    DOTNET_RUNNING_IN_CONTAINER=true

ADD bin/ /VolumeTest/Code

ENTRYPOINT ["/VolumeTest/Code/VolumeTestApp.exe"]
