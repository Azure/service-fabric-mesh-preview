Param
(
    [Parameter(Mandatory=$True)]
    [ValidateSet('1709', 'Linux', 'sac2016')]
    [String]$OsTag,
  
    [Parameter(Mandatory=$False)]
    [String]$ContainerVersion = '1.0',

    [Parameter(Mandatory=$True)]
    [String]$ContainerRegistry
)

$MyScriptRoot = Split-Path $MyInvocation.MyCommand.Path
Push-Location $MyScriptRoot\

# Build images
Write-Host "Starting building ServiceFabricSBZVoting for $OsTag..."

Push-Location ..\ServiceFabricSBZVoting
docker build ..\ -f Dockerfile-$OsTag -t servicefabricsbzvotingweb:latest-$OsTag
Pop-Location

Write-Host "Done building ServiceFabricSBZVoting for $OsTag..."

Write-Host "Starting building ServiceFabricSBZData for $OsTag..."

Push-Location ..\ServiceFabricSBZVotingData
docker build ..\ -f Dockerfile-$OsTag -t servicefabricsbzvotingdata:latest-$OsTag
Pop-Location

Write-Host "Done building ServiceFabricSBZData for $OsTag..."

# Tag images
Write-Host "Tagging iamges for $ContainerRegistry..."
docker tag servicefabricsbzvotingweb:latest-$OsTag $ContainerRegistry/votingfrontend:$ContainerVersion-$OsTag
docker tag servicefabricsbzvotingdata:latest-$OsTag $ContainerRegistry/votingdata:$ContainerVersion-$OsTag