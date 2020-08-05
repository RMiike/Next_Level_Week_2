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
            [FromServices] IUserServices _userServices,
            [FromBody] UserDTO userDTO)
        {
            var userResult = _userServices.Create(userDTO);

            return Ok();
        }
    }
}
