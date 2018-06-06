using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VotingData.Controllers
{
    [Route("api/[controller]")]
    public class VotesDataController : Controller
    {
        private static Dictionary<string, int> _votes = new Dictionary<string, int>();
        private readonly ILogger _logger;
        private DateTime _timer;

        public VotesDataController(ILogger<VotesDataController> logger)
        {
            _logger = logger;
        }

        // GET api/votes
        [HttpGet]
        public IActionResult Get(string name)
        {
            _timer = DateTime.Now;
            _logger.LogInformation("Getting votes");

            _logger.LogInformation($"Returning votes in { DateTime.Now.Millisecond - _timer.Millisecond }ms");
            return Json(_votes);
        }

        // PUT api/votes/name
        [HttpPut("{name}")]
        public IActionResult Put(string name)
        {
            _timer = DateTime.Now;
            _logger.LogInformation($"Saving vote for { name }");

            if (!_votes.ContainsKey(name.ToLower()))
            {
                _votes.Add(name.ToLower(), 1);
            }
            else
            {
                _votes[name.ToLower()] += 1;
            }

            _logger.LogInformation($"Saved vote in { DateTime.Now.Millisecond - _timer.Millisecond }ms");

            return new OkResult();
        }

        // DELETE api/votes/name
        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            _timer = DateTime.Now;
            _logger.LogInformation($"Delete vote option { name }");

            if (!_votes.ContainsKey(name.ToLower()))
            {
                _logger.LogError($"Didn't find vote option { name }...");
                return new NotFoundObjectResult(name);
            }
            else
            {
                _logger.LogInformation($"Removed vote option {name}...");
                _votes.Remove(name.ToLower());
            }

            _logger.LogInformation($"Deleted vote option { DateTime.Now.Millisecond - _timer.Millisecond }ms");

            return new OkResult();
        }
    }
}