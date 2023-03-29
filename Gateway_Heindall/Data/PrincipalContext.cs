using Gateway_Heindall.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Gateway_Heindall.Data
{
    public class PrincipalContext : DbContext
    {
        public PrincipalContext(DbContextOptions<PrincipalContext> options)
       : base(options) => Database.EnsureCreated();

        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Integrador> Integradores { get; set; }
        public DbSet<IntegradordoUser> IntegradoresdoUser { get; set; }
        public DbSet<IntegradordoUserTemp> IntegradoresdoUserTemp { get; set; }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
