using Microsoft.AspNetCore.Mvc;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("user")]
        public IActionResult Create()
        {
            return Ok();
        }
    }
}
