using Microsoft.EntityFrameworkCore;

namespace ContemporaryFinal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<GroupMember> GroupMembers { get; set; }

        
    }
}
