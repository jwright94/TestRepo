using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private static Random random = new Random();
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var greetings = new string[] { "hello", "hi", "hey", "henlo", "hola", "oi", "sup" };
            return greetings[random.Next(greetings.Length)];
        }
    }
}
