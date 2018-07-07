// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabricMesh.Fireworks.Worker
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    // send ping to counter, until cancellaed
    internal class PingClient
    {
        private const string OBJECTCOUNTER_ADDRESS = "OBJECTCOUNTER_ADDRESS";
        private const string PING_INTERVAL_MILLIS = "PING_INTERVAL_MILLIS";
        private const string PING_FUZZ_INTERVAL_MILLIS = "PING_FUZZ_INTERVAL_MILLIS";
        private const string OBJECT_TYPE = "OBJECT_TYPE";
        private const string OBJECT_VERSION = "OBJECT_VERSION";
        private const string OBJECT_ID = "Fabric_Id";

        private static Random Rand;
        private static int PingIntervalMillis;
        private static int PingFuzzIntervalMillis;

        private static readonly string ObjectCounterAddress;
        private static readonly string ObjectType;
        private static readonly string ObjectVersion;
        private static readonly string ObjectId;

        private static readonly HttpClient Client;
        private static bool ReportError;

        static PingClient()
        {
            Rand = new Random();
            ReportError = true;

            if (Environment.GetEnvironmentVariable(OBJECTCOUNTER_ADDRESS) != null)
            {
                ObjectCounterAddress = Environment.GetEnvironmentVariable(OBJECTCOUNTER_ADDRESS);
            }
            else
            {
                ObjectCounterAddress = "web:8080";
            }

            if (!int.TryParse(Environment.GetEnvironmentVariable(PING_INTERVAL_MILLIS), out PingIntervalMillis))
            {
                PingIntervalMillis = 5000;
            }

            if (!int.TryParse(Environment.GetEnvironmentVariable(PING_FUZZ_INTERVAL_MILLIS), out PingFuzzIntervalMillis))
            {
                PingFuzzIntervalMillis = 2000;
            }

            if (Environment.GetEnvironmentVariable(OBJECT_TYPE) != null)
            {
                ObjectType = Environment.GetEnvironmentVariable(OBJECT_TYPE);
            }
            else
            {
                ObjectType = "worker";
            }

            if (Environment.GetEnvironmentVariable(OBJECT_VERSION) != null)
            {
                ObjectVersion = Environment.GetEnvironmentVariable(OBJECT_VERSION);
            }
            else
            {
                ObjectVersion = "v1";
            }

            if (Environment.GetEnvironmentVariable(OBJECT_ID) != null)
            {
                ObjectId = Environment.GetEnvironmentVariable(OBJECT_ID);
            }
            else
            {
                ObjectId = Guid.NewGuid().ToString();
            }


            Client = new HttpClient();
        }

        public static async Task SendPingAsync(CancellationToken cancellationToken)
        {
            var requestUri = new Uri($"http://{ObjectCounterAddress}/api/values?id={ObjectId}&type={ObjectType}&version={ObjectVersion}");
            Console.WriteLine($"Sending ping to {requestUri}");

            while (!cancellationToken.IsCancellationRequested)
            {
                await SendData(requestUri, cancellationToken);
                await Task.Delay(GetDueTime(), cancellationToken);
            }
        }

        private static async Task<bool> SendData(Uri requestUri, CancellationToken cancellationToken)
        {
            try
            {
                var request = new HttpRequestMessage()
                {
                    Method = HttpMethod.Post,
                    Content = new StringContent(string.Empty, Encoding.UTF8),
                    RequestUri = requestUri
                };

                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("text/plain; charset=utf-8");

                var response = await Client.SendAsync(request, cancellationToken);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    if (ReportError)
                    {
                        Console.WriteLine("Error in sending the data " + response);
                        ReportError = false;
                    }
                }
                else
                {
                    ReportError = true;
                    return true;
                }
            }
            catch (Exception e)
            {
                if (ReportError)
                {
                    Console.WriteLine("Error in sending the data " + e.Message);
                    ReportError = false;
                }
            }

            return false;
        }

        private static TimeSpan GetDueTime()
        {
            var dueTimeMillis =
                Rand.Next(PingFuzzIntervalMillis) +
                Rand.Next(PingFuzzIntervalMillis);

            return TimeSpan.FromMilliseconds(dueTimeMillis);
        }
    }
}
