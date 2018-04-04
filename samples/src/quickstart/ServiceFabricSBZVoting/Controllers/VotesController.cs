using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ServiceFabricSBZVoting.Controllers
{
    [Route("api/[controller]")]
    public class VotesController : Controller
    {
        private readonly HttpClient _httpClient;

        private static Uri backendUrl = new Uri($"http://{Environment.GetEnvironmentVariable("Voting_BackendHostName")}:{Environment.GetEnvironmentVariable("Voting_BackendHostPort")}/api/votesdata");

        public VotesController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET api/votes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = new Dictionary<string, int>();

            using (HttpResponseMessage response = await _httpClient.GetAsync(backendUrl))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<Dictionary<string, int>>(await response.Content.ReadAsStringAsync());
                }
            }

            Console.WriteLine("Returning votes...");

            return this.Json(result);
        }

        // PUT api/votes/name
        [HttpPut("{name}")]
        public async Task<ContentResult> Put(string name)
        {
            using (HttpResponseMessage response = await _httpClient.PutAsync($"{backendUrl}/{name}", new StringContent("")))
            {
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
            using (HttpResponseMessage response = await _httpClient.DeleteAsync($"{backendUrl}/{name}"))
            {
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return this.StatusCode((int)response.StatusCode);
                }
            }

            Console.WriteLine("Deleted vote option...");

            return new OkResult();
        }
    }
}
