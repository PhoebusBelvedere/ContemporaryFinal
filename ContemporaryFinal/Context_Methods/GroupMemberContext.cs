using Microsoft.EntityFrameworkCore;

namespace ContemporaryFinal.Context_Methods
{
    public class GroupMemberContext
    {
        private readonly CF_DBContext _context;
        public GroupMemberContext(CF_DBContext context)
        {
            _context = context;
        }

        public List<GroupMember> GetAllMembers()
        {
            List<GroupMember> members = _context.GroupMembers.ToList();
            return members;
        }

        public GroupMember GetMemberById(int id)
        {
            return _context.GroupMembers.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveMember(int id)
        {
            var member = this.GetMemberById(id);
            if (member == null)
            {
                return null;
            }
            try
            {
                _context.GroupMembers.Remove(member);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? AddMember(GroupMember member)
        {
            try
            {
                _context.GroupMembers.Add(member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public int? UpdateMember(GroupMember member)
        {
            var memberToUpdate = this.GetMemberById(member.Id);
            if(memberToUpdate == null)
            {
                return null;
            }
            memberToUpdate.Name = member.Name;
            memberToUpdate.BirthDate = member.BirthDate;
            memberToUpdate.Program = member.Program;
            memberToUpdate.SchoolYear = member.SchoolYear;

            try
            {
                _context.GroupMembers.Update(memberToUpdate);
                _context.SaveChanges();
                return 1; 
            
            }
            catch(Exception)
            {
                return 0;
            }


        }

    }
}
