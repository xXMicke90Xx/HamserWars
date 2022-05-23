using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamserWarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        // GET: api/<HamsterController>
        [HttpGet("/hamsters")]
        
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("/hamsters/random")]      
        public IEnumerable<string> GetRandom()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HamsterController>/5
        [HttpGet("/hamsters/{id}")]
        public string GetOne(int id)
        {
            return "value";
        }

        // POST api/<HamsterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HamsterController>/5
        [HttpPut("/hamsters/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HamsterController>/5
        [HttpDelete("/hamsters/{id}")]
        public void Delete(int id)
        {
        }
    }
}
