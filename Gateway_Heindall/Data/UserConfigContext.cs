using Gateway_Heindall.Models;
using Microsoft.EntityFrameworkCore;

namespace Gateway_Heindall.Data
{
    public class UserConfigContext : DbContext
    {
        public UserConfigContext(DbContextOptions<UserConfigContext> options)
      : base(options) => Database.EnsureCreated();

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
