using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthenticationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Welcome! You have accessed a protected API.");
        }
    }
}