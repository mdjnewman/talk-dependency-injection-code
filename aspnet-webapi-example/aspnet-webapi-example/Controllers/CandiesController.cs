using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_webapi_example.Controllers
{
    [Route("api/[controller]")]
    public class CandiesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var store = new CandyStore();
            var candies = store.GetCandies();
            return candies;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }

    public class CandyStore
    {
        public string[] GetCandies()
        {
            return new string[] { "Snicker", "Twix" };
        }
    }
}
