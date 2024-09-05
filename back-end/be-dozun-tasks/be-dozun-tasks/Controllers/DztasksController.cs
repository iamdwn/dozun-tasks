using be_dozun_tasks.Models;
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

        [HttpPost]
        public IActionResult Post(Tasks task)
        {
            return Ok(_dztasksService.AddTasks(task));
        }

        [HttpPut]
        public IActionResult Put(Tasks task)
        {
            return Ok(_dztasksService.UpdateTasks(task));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_dztasksService.DeleteTasks(id));
        }
    }
}

