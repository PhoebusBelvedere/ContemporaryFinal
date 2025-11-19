using Microsoft.AspNetCore.Mvc;

namespace ContemporaryFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController2 : ControllerBase
    {
        public IActionResult Index()
        {
            return;
        }
    }
}
