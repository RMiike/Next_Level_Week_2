using Microsoft.AspNetCore.Mvc;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        [HttpPost("classes")]
        public IActionResult Create()
        {
            return Ok();
        }
    }
}
