using Microsoft.EntityFrameworkCore;
namespace hobbyHub.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Hobby> Hobby { get; set; }
        public DbSet<association> association { get; set; }
    }
}