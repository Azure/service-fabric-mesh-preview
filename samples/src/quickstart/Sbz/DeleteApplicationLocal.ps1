$MyScriptRoot = Split-Path $MyInvocation.MyCommand.Path
Push-Location $MyScriptRoot\SDK

Write-Host "Deleting application..."
.\Delete-ServiceFabricApplicationResource_Local.ps1 -ClusterHttpEndpoint http://localhost:19080 -ApplicationResourcename "SbzVotingApp"

Pop-Location