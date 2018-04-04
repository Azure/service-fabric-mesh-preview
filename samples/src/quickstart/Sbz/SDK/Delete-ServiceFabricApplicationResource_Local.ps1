# ------------------------------------------------------------
# Copyright (c) Microsoft Corporation.  All rights reserved.
# Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
# ------------------------------------------------------------


<#
    .SYNOPSIS 
    Deletes a Service Fabric application resource from local Service Fabric cluster.

    .DESCRIPTION
    This script deletes a Service Fabric application resource to local Service Fabric cluster.

    .PARAMETER ClusterHttpEndpoint
    Http endpoint of the service fabric cluster.

    .PARAMETER ApplicationResourcename
    Name of the applicaiton Resource to create.
    #>

    Param
    (
        [Parameter(Mandatory=$true)]
        [String]$ClusterHttpEndpoint,

        [Parameter(Mandatory=$true)]
        [String]$ApplicationResourcename
    )


    # Connect to cluster
    $currentDir = Split-Path $SCRIPT:MyInvocation.MyCommand.Path -parent
    $psModulePath = [io.path]::combine($CurrentDir, "Microsoft.ServiceFabric.Powershell")
    import-module $psModulePath
    Connect-SFCluster -Endpoint $ClusterHttpEndpoint

    # invoke PS cmdlets to create the applicaiton resource    
    Remove-SFApplicationResource -ApplicationResourceName $ApplicationResourcename