// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Web
{
    using System;
    using System.Net.WebSockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using VisualObjects.Common;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IVisualObjectsBox>(CreateVisualObjectsBox());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
            var webSocketOptions = new WebSocketOptions()
            {
                KeepAliveInterval = TimeSpan.FromSeconds(120),
            };
            app.UseWebSockets(webSocketOptions);

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/data")
                {
                    if (context.WebSockets.IsWebSocketRequest)
                    {
                        WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
                        await SendData(context, webSocket, app.ApplicationServices.GetService<IVisualObjectsBox>());
                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                    }
                }
                else
                {
                    await next();
                }

            });
        }

        private async Task SendData(HttpContext context, WebSocket webSocket, IVisualObjectsBox objectBox)
        {
            using (webSocket)
            {
                while (true)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(objectBox.GetJson());

                    try
                    {
                        await webSocket.SendAsync(
                            new ArraySegment<byte>(buffer, 0, buffer.Length),
                            WebSocketMessageType.Text,
                            true,
                            CancellationToken.None);

                        if (webSocket.State != WebSocketState.Open)
                        {
                            break;
                        }
                    }
                    catch (WebSocketException)
                    {
                        // If the browser quit or the socket was closed, exit this loop so we can get a new browser socket.
                        break;
                    }

                    // wait a bit and continue. This determines the client refresh rate.
                    await Task.Delay(TimeSpan.FromMilliseconds(10), CancellationToken.None);
                }
            }
        }


        private static IVisualObjectsBox CreateVisualObjectsBox()
        {
            TimeSpan refreshInterval = TimeSpan.FromMilliseconds(10);
            if (long.TryParse(Environment.GetEnvironmentVariable("BOX_REFRESH_INTERVAL_MILLIS"), out long refreshIntervalMillis))
            {
                refreshInterval = TimeSpan.FromMilliseconds(refreshIntervalMillis);
            }

            TimeSpan expiryInterval = TimeSpan.FromMilliseconds(10000);
            if (long.TryParse(Environment.GetEnvironmentVariable("BOX_EXPIRY_INTERVAL_MILLIS"), out long expiryIntervalMillis))
            {
                expiryInterval = TimeSpan.FromMilliseconds(expiryIntervalMillis);
            }

            Console.WriteLine("Creating box with Expiry = " + expiryInterval + ", Refresh = " + refreshInterval);
            return new VisualObjectsBox(expiryInterval, refreshInterval);
        }
    }
}
