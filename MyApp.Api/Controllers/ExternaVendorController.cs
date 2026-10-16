using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Queries;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternaVendorController(ISender isnder) : ControllerBase
    {
        [HttpGet("GetTasks")]
        public async Task<IActionResult> GetTaskData()
        {
           var result = await isnder.Send(new GetTodoDatatQuery());
            return Ok(result);
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await isnder.Send(new GetUserQuery());
            return Ok(result);
        }
    }
}
