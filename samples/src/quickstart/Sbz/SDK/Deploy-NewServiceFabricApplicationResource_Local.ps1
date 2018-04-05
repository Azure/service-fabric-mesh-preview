# ------------------------------------------------------------
# Copyright (c) Microsoft Corporation.  All rights reserved.
# Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
# ------------------------------------------------------------

<#
    .SYNOPSIS 
    Deploys a new Service Fabric application resource to local Service Fabric cluster.

    .DESCRIPTION
    This script creates a Service Fabric application resource to local Service Fabric cluster.

    .PARAMETER ClusterHttpEndpoint
    Http endpoint of the service fabric cluster.

    .PARAMETER ApplicationResourcename
    Name of the applicaiton Resource to create.

    .PARAMETER ResourceDescriptionFile
    Path to json file containing resource description.

    .PARAMETER OverwriteBehavior
    Overwrite Behavior if an application resource exists in the cluster with the same name. Available Options are Never, Always.
    Never will not remove the existing application resource. This is the default behavior.
    Always will remove the existing application resource.

    #>

    Param
    (
        [Parameter(Mandatory=$true)]
        [String]$ClusterHttpEndpoint,

        [Parameter(Mandatory=$true)]
        [String]$ApplicationResourcename,

        [Parameter(Mandatory=$true)]
        [String]$ResourceDescriptionFile,

        [ValidateSet('Never','Always')]
        [String]$OverwriteBehavior = 'Never'
    )

    # Connect to cluster
    $currentDir = Split-Path $SCRIPT:MyInvocation.MyCommand.Path -parent
    $psModulePath = [io.path]::combine($CurrentDir, "Microsoft.ServiceFabric.Powershell")
    import-module $psModulePath
    Connect-SFCluster -Endpoint $ClusterHttpEndpoint

    # Apply OverwriteBehavior if an applciation with same name already exists.
    $app = Get-SFApplicationResource -ApplicationResourceName $ApplicationResourcename

    if ($app)
    {
        if($OverwriteBehavior.Equals("Never"))
        {
            $errMsg = "An application resource with name '$ApplicationResourceName' already exists.
            You must first remove the existing application before a new application resource name can be created or provide a new name for the application resource."
            throw $errMsg
        }

        if($OverwriteBehavior.Equals("Always"))
        {
           Remove-SFApplicationResource -ApplicationResourceName $ApplicationResourcename
        }
    }

    # invoke PS cmdlets to create the applicaiton resource        
    New-SFApplicationResource -ApplicationResourceName $ApplicationResourcename -ResourceDescriptionFile $ResourceDescriptionFile