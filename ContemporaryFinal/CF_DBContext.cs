using Microsoft.EntityFrameworkCore;

namespace ContemporaryFinal
{
    //Db context class to create our database
    public class CF_DBContext : DbContext
    {
        public CF_DBContext(DbContextOptions<CF_DBContext> options)
            : base(options)
        {
        }

        // 4 tables, add other tables below here
        public DbSet<GroupMember> GroupMembers { get; set; }
       


        protected override void OnModelCreating(ModelBuilder mb)
        {
            //creating table with groupmember data
            base.OnModelCreating(mb);
            mb.Entity<GroupMember>().HasData(
                new GroupMember
                {
                    Id = 1,
                    Name = "Ian Wolfram",
                    BirthDate = new DateTime(2005, 7, 14),
                    Program = "Information Technology",
                    SchoolYear = "Junior"

                },
                new GroupMember
                {
                    Id = 2,
                    Name = "Madeline Pederson",
                    BirthDate = new DateTime(2004, 7,23),
                    Program = "Information Technology",
                    SchoolYear = "Junior"

                }





                );
                
                
                
                
                
        }



        
    }
}
