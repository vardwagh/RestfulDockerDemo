using Microsoft.AspNetCore.Mvc;

namespace RestfulDockerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            Console.WriteLine("Hello, World!");
            return "Hello, World!";
            
        }
    }
}