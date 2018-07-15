// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabricMesh.Fireworks.Worker
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            PingClient.SendPingAsync(CancellationToken.None).Wait();
        }
    }
}
