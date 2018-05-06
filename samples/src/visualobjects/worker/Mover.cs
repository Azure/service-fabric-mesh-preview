// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Worker
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using VisualObjects.Common;

    // moves a visual object and save it to the store
    internal class Mover
    {
        private const string MoveSpeedEnvVar = "OBJECT_MOVE_INTERVAL_MILLIS";
        private const string EnableRotationEnv = "OBJECT_ENABLE_ROTATION";

        private static readonly TimeSpan MoveSpeed;
        private static readonly bool Rotate;

        static Mover()
        {
            if (bool.TryParse(
                Environment.GetEnvironmentVariable(EnableRotationEnv),
                out bool rotate))
            {
                Rotate = rotate;
            }
            else
            {
                Rotate = false;
            }

            if (long.TryParse(
                Environment.GetEnvironmentVariable(MoveSpeedEnvVar),
                out long millis))
            {
                MoveSpeed = TimeSpan.FromMilliseconds(millis);
            }
            else
            {
                MoveSpeed = TimeSpan.FromMilliseconds(50);
            }
        }


        public static async Task MoveAsync(
            IStateStore stateStore,
            CancellationToken cancellationToken)
        {
            long totalMoves = 0;
            long successfulMoves = 0;
            while (!cancellationToken.IsCancellationRequested)
            {
                totalMoves++;
                var obj = await ReadObjectAsync(stateStore, cancellationToken);
                if (obj != null)
                {
                    if (await DataSender.SendData(obj.Name, obj.ToJson(), cancellationToken))
                    {
                        obj.Move(Rotate);
                        await WriteObjectAsync(stateStore, obj, cancellationToken);
                        successfulMoves++;
                    }
                }

                if ((totalMoves % 1000) == 0)
                {
                    Console.WriteLine($"Completed {successfulMoves}/{totalMoves} sucessful moves.");
                }

                await Task.Delay(MoveSpeed);
            }
        }

        public static async Task<VisualObject> ReadObjectAsync(
            IStateStore stateStore,
            CancellationToken cancellationToken)
        {
            try
            {
                return await stateStore.ReadAsync(cancellationToken);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in reading the object. {e.ToString()}");
                return null;
            }
        }

        public static async Task WriteObjectAsync(
            IStateStore stateStore,
            VisualObject obj,
            CancellationToken cancellationToken)
        {
            try
            {
                await stateStore.WriteAsync(obj, cancellationToken);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in writing the object. {e.ToString()}");
            }
        }
    }
}
