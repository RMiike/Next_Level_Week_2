using Microsoft.AspNetCore.Mvc;
using Proffy.Core.Contracts;
using Proffy.Core.DTOs;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        [HttpPost("classes")]
        public IActionResult Create(
            [FromServices] ICreateClassServices _createClassServices,
            [FromBody] CreateClassDTO createClassDTO)
        {
            var result = _createClassServices.Create(createClassDTO);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("classes")]
        public IActionResult Index(
            [FromQuery] int? week_day, string? subject, string? time,
            [FromServices] ICreateClassServices _createClassServices)
        {
            var result = _createClassServices.Index(week_day, subject, time);

            if(result.Success)
                return Ok(result);

            return BadRequest();
        }
    }
}
