using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.commands;
using MyApp.Core.Entities;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> GetEmployees([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }
    }
}
