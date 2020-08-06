using Microsoft.AspNetCore.Mvc;
using Proffy.Core.Contracts;
using Proffy.Core.DTOs;

namespace Proffy.WebAPI.Controllers.v1
{
    [Route("v1")]
    [ApiController]
    public class ConnecitonsController : ControllerBase
    {
        
        [HttpPost("connections")]
        public IActionResult Create(
            [FromServices] IConnectionServices connectionServices,
            [FromBody] ConnectionDTO connectionDTO
            )
        {
            var result = connectionServices.Create(connectionDTO);

            if (result.Success)
                return Ok(result);

            return BadRequest();
        }

        [HttpGet("connections")]
        public IActionResult Index(
            [FromServices] IConnectionServices connectionServices
            )
        {
            var result = connectionServices.Index();

            if (result.Success)
                return Ok(result);

            return BadRequest();
        }
    }
}
