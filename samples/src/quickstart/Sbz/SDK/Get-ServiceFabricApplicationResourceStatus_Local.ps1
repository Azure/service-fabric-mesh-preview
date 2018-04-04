# ------------------------------------------------------------
# Copyright (c) Microsoft Corporation.  All rights reserved.
# Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
# ------------------------------------------------------------

<#
    .SYNOPSIS 
    Gets a Service Fabric application resource from local Service Fabric cluster.

    .DESCRIPTION
    This script gets the Service Fabric application resource from local Service Fabric cluster.

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

    $ready = $false
    $retryCount = 20

    # Connect to cluster
    $currentDir = Split-Path $SCRIPT:MyInvocation.MyCommand.Path -parent
    $psModulePath = [io.path]::combine($CurrentDir, "Microsoft.ServiceFabric.Powershell")
    import-module $psModulePath
    Connect-SFCluster -Endpoint $ClusterHttpEndpoint


    do
    {
        try
        {
            $app = Get-SFApplicationResource -ApplicationResourceName $ApplicationResourcename
            if ($app)
            {                
                if($app.Status -eq "Ready")
                {
                    $ready = $true
                }               
                   
            }
            else
            {
                Write-Host "Waiting for the application resource to be created."
            }
            Write-Host ""
        }
        finally
        {
            if(!$ready)
            {
                Start-Sleep -Seconds 2
            }
            $retryCount--
        }
    } while (!$ready -and $retryCount -gt 0)

    if(!$ready)
    {
        Write-Host "Something is taking too long, the application resource is still not ready."
    }
    else
    {
        Write-Host "The application resource is ready."
    }