## TO-DO CLI

Login-AzureRmAccount
Set-AzureRmContext -SubscriptionId ""
New-AzureRmResourceGroup -Name Pristine -Location eastus
New-AzureRmResourceGroupDeployment -Name Pristine -ResourceGroupName SbzVotingLinux -TemplateFile .\SbzVotingARM.json