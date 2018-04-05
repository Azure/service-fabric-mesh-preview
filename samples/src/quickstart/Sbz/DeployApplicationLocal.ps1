$MyScriptRoot = Split-Path $MyInvocation.MyCommand.Path
Push-Location $MyScriptRoot\

$JsonFile = "$MyScriptRoot\SbzVoting.json"

# Generete SF_SBZ_JSON
Write-Host "Generating JSON deployment file..."
Push-Location .\SDK\SfSbzYamlMerge
.\SfSbzYamlMerge.exe /i:"..\..\VotingApp.yaml" /i:"..\..\VotingWeb.yaml" /i:"..\..\VotingData.yaml" /o:$JsonFile /of:SF_SBZ_JSON
Pop-Location

# Deploy Application
Write-Host "Deploying application..."
Push-Location .\SDK
.\Deploy-NewServiceFabricApplicationResource_Local.ps1 -ClusterHttpEndpoint http://localhost:19080 -ApplicationResourcename "SbzVotingApp" -ResourceDescriptionFile $JsonFile
Pop-Location