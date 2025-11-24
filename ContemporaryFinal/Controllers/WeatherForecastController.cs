/*using Microsoft.AspNetCore.Mvc;

namespace ContemporaryFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet]
        public IActionResult Get(int id)
        {
            var members = _context.GetAllMembers();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var member = _context.GetMemberById(id);
            return Ok(member);
        }

        [HttpPost]
        public IActionResult Post(GroupMember member)
        {
            return;
        }

        [HttpPut("{id?}")]
        public IActionResult Put(GroupMember member)
        {
            
        }
    }
}
*/