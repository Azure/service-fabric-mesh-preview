// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Worker
{
    using System.Threading;
    using System.Threading.Tasks;
    using VisualObjects.Common;

    internal interface IStateStore
    {
        Task<VisualObject> ReadAsync(CancellationToken cancellationToken);

        Task WriteAsync(VisualObject obj, CancellationToken cancellationToken);

    }
}
