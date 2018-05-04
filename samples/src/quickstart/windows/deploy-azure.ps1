"C:\Program Files\Microsoft SDKs\Service Fabric\Tools\SfSbzYamlMerge\SfSbzYamlMerge.exe" /i:".\VotingApp\App Resources\app.yaml" /i:".\VotingData\Service Resources\service.yaml" /i:".\VotingWeb\Service Resources\service.yaml" /i:."\VotingApp\App Resources\network.yaml" /o:.\Deployment /of:SF_SBZ_RP_JSON /r:westus

$subscriptionId = ''
$rgname = ''
$location = 'westus'

#Login-AzureRmAccount -Subscription $subscriptionId
New-AzureRmResourceGroup -Name $rgname -Location $location

$parameters = @{"location" = $location}

New-AzureRmResourceGroupDeployment -Name VotingDeployment -ResourceGroupName $rgname -TemplateFile .\Deployment\merged-arm_rp.json -TemplateParameterObject $parameters