// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Worker
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    // sends the location of the visual object, until cancelled
    internal class DataSender
    {
        private const string SendAddressEnvVar = "BOX_ADDRESS";
        private static readonly String SendAddress;
        private static readonly HttpClient Client;
        private static bool ReportError = true;

        static DataSender()
        {
            if (Environment.GetEnvironmentVariable(SendAddressEnvVar) != null)
            {
                SendAddress = Environment.GetEnvironmentVariable(SendAddressEnvVar);
            }
            else
            {
                SendAddress = "web:80";
            }

            Client = new HttpClient();
        }

        public static async Task<bool> SendData(string objectId, string content, CancellationToken cancellationToken)
        {
            try
            {
                var request = new HttpRequestMessage()
                {
                    Method = HttpMethod.Post,
                    Content = new StringContent(content, Encoding.UTF8),
                    RequestUri = new Uri($"http://{SendAddress}/api/values?id={objectId}"),
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
    }
}
