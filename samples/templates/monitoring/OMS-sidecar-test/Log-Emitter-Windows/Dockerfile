FROM microsoft/powershell:windowsservercore-1709
# FROM microsoft/nanoserver:1709

SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]
ADD loop.ps1 /

# run script in background
# RUN Start-Job { .\loop.ps1 }
### this assumes that the file mount path exists.
# RUN Start-Job { .\loop.ps1 }
ENTRYPOINT .\loop.ps1