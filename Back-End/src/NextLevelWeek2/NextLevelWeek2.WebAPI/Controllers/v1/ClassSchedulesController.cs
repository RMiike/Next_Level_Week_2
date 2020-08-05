using Microsoft.AspNetCore.Mvc;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class ClassSchedulesController : ControllerBase
    {
        [HttpPost(" class-schedule")]
        public IActionResult Create()
        {
            return Ok();
        }
    }
}
