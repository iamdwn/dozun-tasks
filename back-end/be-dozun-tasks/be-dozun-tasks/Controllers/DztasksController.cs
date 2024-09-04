using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace be_dozun_tasks.Controllers
{
    [Route("v1/api/dztasks")]
    [ApiController]
    public class DztasksController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("{id}")]
        public void Post([FromBody] string value)
        {

        }

        [HttpPut("{id}")]
        public void Put([FromBody] string value)
        {
        
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}

