using Microsoft.AspNetCore.Mvc;
using Proffy.Core.Contracts;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("user")]
        public IActionResult Create(
            IUserServices _userServices)
        {
            return Ok();
        }
    }
}
