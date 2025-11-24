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
        public IActionResult Get()
        {
            var members = _context.GetAllMembers();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var member = _context.GetMemberById(id);
            if (member == null)
            {
                return NotFound(id);
            }
            return Ok(member);
        }

        [HttpPost]
        public IActionResult Post(GroupMember member)
        {
           var result = _context.AddMember(member);
           
            if (result == 0)
            {
                return StatusCode(500, "An error occured");
            }
            return Ok();
        }
            
        

        [HttpPut]
        public IActionResult Put(GroupMember member)
        {
            var result = _context.UpdateMember(member);
            if (result == null)
            {
                return NotFound(member);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured");
            }
            return Ok();
        }




        [HttpDelete("{id?}")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveMember(id);

            if (result == null)
            {
                return NotFound(id);
                
            }
           
            return NoContent();
            
        }

       






    }
}
