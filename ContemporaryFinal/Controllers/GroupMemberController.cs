using Microsoft.AspNetCore.Mvc;

namespace ContemporaryFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupMemberController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            
        }

        [HttpPost]
        public IActionResult Create([FromBody] object groupMember)
        {
            return;
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] object groupMember)
        {
            return;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return;
        }
       






    }
}
