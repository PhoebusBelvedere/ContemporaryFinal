using Microsoft.AspNetCore.Mvc;

namespace ContemporaryFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController1 : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
