using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet("data")]
        public IActionResult GetSecureData()
        {
            var username = User.Identity?.Name;
            return Ok($"Hello {username}, this is a protected API response.");
        }

        [AllowAnonymous]
        [HttpGet("public")]
        public IActionResult GetPublicData()
        {
            return Ok("This is a public API response. No token needed.");
        }
    }
}
