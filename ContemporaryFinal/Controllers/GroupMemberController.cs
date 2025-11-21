using Microsoft.AspNetCore.Mvc;
using ContemporaryFinal.Context_Methods;

namespace ContemporaryFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupMemberController : ControllerBase
    {

        private readonly GroupMemberContext _context;
        
        public GroupMemberController(GroupMemberContext context)
        {
            _context = context;
        }


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

       

        [HttpDelete("{id?}")]
        public IActionResult Delete(int id)
        {
            var member = _context.RemoveMember(id);

            if (member == null)
                return NotFound(id);

            if (string.IsNullOrEmpty(member.Name))
                return StatusCode(500, "An error occured");

            return Ok();
            
        }

       






    }
}
