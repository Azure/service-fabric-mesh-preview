# ------------------------------------------------------------
# Copyright (c) Microsoft Corporation.  All rights reserved.
# Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
# ------------------------------------------------------------

<#
    .SYNOPSIS 
    Updates a Service Fabric application resource running in local Service Fabric cluster.

    .DESCRIPTION
    This script updates a Service Fabric application resource to local Service Fabric cluster.

    .PARAMETER ClusterHttpEndpoint
    Http endpoint of the service fabric cluster.

    .PARAMETER ResourceDescriptionFile
    Path to json file containing resource description.

    .PARAMETER PartialYamlFiles
    Comma seprated list of Path to partial yaml files created by Visual Studio Solution. The files will be merged to create an application resource in Service Fabric cluster.    

    #>

    Param
    (
        [Parameter(Mandatory=$true)]
        [String]$ClusterHttpEndpoint,

        [Parameter(Mandatory=$true)]
        [String]$ApplicationResourcename,

        [Parameter(Mandatory=$true)]
        [String]$ResourceDescriptionFile
    )

    # Connect to cluster
    $currentDir = Split-Path $SCRIPT:MyInvocation.MyCommand.Path -parent
    $psModulePath = [io.path]::combine($CurrentDir, "Microsoft.ServiceFabric.Powershell")
    import-module $psModulePath
    Connect-SFCluster -Endpoint $ClusterHttpEndpoint

    # invoke PS cmdlets to update the applicaiton resource        
    Update-SFApplicationResource -ApplicationResourceName $ApplicationResourcename -ResourceDescriptionFile $ResourceDescriptionFile