## TO-DO CLI

Login-AzureRmAccount
Set-AzureRmContext -SubscriptionId "c484c80e-0a6f-4470-86de-697ecee16984"
New-AzureRmResourceGroup -Name Pristine -Location eastus
New-AzureRmResourceGroupDeployment -Name Pristine -ResourceGroupName SbzVotingLinux -TemplateFile .\SbzVotingARM.json