using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITest5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        [Route("/")]

        public IEnumerable<string> Get()
        {
            return new string[] { "This", "is", "a", "test" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("/")]
        public void Post([FromBody] dynamic value)
        {
            var test = JsonSerializer.Serialize(value);
            Console.WriteLine(test);

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        [Route("/")]

        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5

        [HttpDelete("{id}")]
        [Route("/")]

        public void Delete(int id)
        {
        }
    }
}
