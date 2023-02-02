using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_Web_API_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
        
    }
}
