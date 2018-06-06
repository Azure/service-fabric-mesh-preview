using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace VotingWeb.Controllers
{
    [Route("api/[controller]")]
    public class VotesController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private DateTime _timer;

#if DEBUG
        private static string backendDNSName = $"{Environment.GetEnvironmentVariable("Voting_BackendHostName")}.votingapp";
#else
        private static string backendDNSName = Environment.GetEnvironmentVariable("Voting_BackendHostName");
#endif

        private static Uri backendUrl = new Uri($"http://{backendDNSName}:{Environment.GetEnvironmentVariable("Voting_BackendHostPort")}/api/votesdata");

        public VotesController(HttpClient httpClient, ILogger<VotesController> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        // GET api/votes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _timer = DateTime.Now;
            _logger.LogInformation("Getting votes");

            var result = new Dictionary<string, int>();

            using (HttpResponseMessage response = await _httpClient.GetAsync(backendUrl))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<Dictionary<string, int>>(await response.Content.ReadAsStringAsync());
                }
            }

            _logger.LogInformation($"Returning votes in { DateTime.Now.Millisecond - _timer.Millisecond }ms");

            return this.Json(result);
        }

        // PUT api/votes/name
        [HttpPut("{name}")]
        public async Task<ContentResult> Put(string name)
        {
            _timer = DateTime.Now;
            _logger.LogInformation("Adding vote");

            using (HttpResponseMessage response = await _httpClient.PutAsync($"{backendUrl}/{name}", new StringContent("")))
            {

                _logger.LogInformation($"Added vote in { DateTime.Now.Millisecond - _timer.Millisecond }ms");

                return new ContentResult()
                {
                    StatusCode = (int)response.StatusCode,
                    Content = await response.Content.ReadAsStringAsync()
                };
            }
        }

        // DELETE api/votes/name
        [HttpDelete("{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            _timer = DateTime.Now;
            _logger.LogInformation("Adding vote");

            using (HttpResponseMessage response = await _httpClient.DeleteAsync($"{backendUrl}/{name}"))
            {
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return this.StatusCode((int)response.StatusCode);
                }
            }

            _logger.LogInformation($"Added vote in { DateTime.Now.Millisecond - _timer.Millisecond }ms");

            return new OkResult();
        }
    }
}
