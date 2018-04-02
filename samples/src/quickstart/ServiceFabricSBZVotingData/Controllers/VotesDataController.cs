using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ServiceFabricSBZVotingData.Controllers
{
    [Route("api/[controller]")]
    public class VotesDataController : Controller
    {
        private static Dictionary<string, int> _votes = new Dictionary<string, int>();

        // GET api/votes
        [HttpGet]
        public IActionResult Get(string name)
        {
            Console.WriteLine("Returning votes...");
            return Json(_votes);
        }

        // PUT api/votes/name
        [HttpPut("{name}")]
        public IActionResult Put(string name)
        {
            if (!_votes.ContainsKey(name.ToLower()))
            {
                Console.WriteLine($"Created vote option {name} and voted...");
                _votes.Add(name.ToLower(), 1);
            }
            else
            {
                Console.WriteLine($"Voting for {name}...");
                _votes[name.ToLower()] += 1;
            }

            return new OkResult();
        }

        // DELETE api/votes/name
        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            if (!_votes.ContainsKey(name.ToLower()))
            {
                Console.WriteLine($"Didn't find vote option {name}...");
                return new NotFoundObjectResult(name);
            }
            else
            {
                Console.WriteLine($"Removed vote option {name}...");
                _votes.Remove(name.ToLower());
            }

            return new OkResult();
        }
    }
}
