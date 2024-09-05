using be_dozun_tasks.Service.Dztasks;
using Microsoft.AspNetCore.Mvc;

namespace be_dozun_tasks.Controllers
{
    [Route("v1/api/dztasks")]
    [ApiController]
    public class DztasksController : ControllerBase
    {
        private readonly IDztasksService _dztasksService;

        public DztasksController(IDztasksService dztasksService)
        {
            _dztasksService = dztasksService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dztasksService.GetTasks());
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

