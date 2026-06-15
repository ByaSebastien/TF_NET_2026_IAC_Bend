using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TF_NET_2026_IAC_Bend.Db;

namespace TF_NET_2026_IAC_Bend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController(MyDbContext Context) : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            List<Product> products = Context.Products.ToList();
            return Ok(products);
        }
    }
}
