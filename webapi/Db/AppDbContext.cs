using Microsoft.EntityFrameworkCore;
using webapi.Db.Entities;

namespace webapi.Db
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
