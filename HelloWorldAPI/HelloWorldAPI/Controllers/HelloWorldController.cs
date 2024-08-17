using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        public ActionResult Index()
        {
            return new JsonResult(new { Message = "Hello Woeld !" });
        }
    }
}
