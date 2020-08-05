using Microsoft.AspNetCore.Mvc;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class ConnectionsController : ControllerBase
    {
        [HttpPost("connection")]
        public IActionResult Create()
        {
            return Ok();
        }
    }
}
