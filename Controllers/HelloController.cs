using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TF_NET_2026_IAC_Bend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, les .NET!");
        }
    }
}
