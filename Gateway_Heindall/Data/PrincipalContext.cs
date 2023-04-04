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
        public DbSet<UserDadosConex> UsersDadosConex { get; set; }
        public DbSet<IntegradordoUser> IntegradoresdoUser { get; set; }

        public DbSet<ConfigGeral> ConfigGerais { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Integrador>()
           .HasOne(i => i.Grupo)
           .WithMany(g => g.Integradores)
           .HasForeignKey(i => i.GrupoId);

            modelBuilder.Entity<UserDadosConex>()
       .HasMany(c => c.IntegradoresdoUser)
       .WithOne(e => e.UserDadosConex)
       .HasForeignKey(e => e.UserDadosConexId);

            modelBuilder.Entity<Integrador>()
                .HasMany(c => c.IntegradoresdoUser)
                .WithOne(e => e.Integrador)
                .HasForeignKey(e => e.IntegradorId);


            /*  modelBuilder.Entity<IntegradordoUser>()
                .HasKey(i => new { i.UserDadosConexId, i.IntegradorId });

            modelBuilder.Entity<IntegradordoUser>()
                .HasOne(i => i.UserDadosConex)
                .WithMany(u => u.Integradores)
                .HasForeignKey(i => i.UserDadosConexId);

            modelBuilder.Entity<IntegradordoUser>()
                .HasOne(i => i.Integrador)
                .WithMany()
                .HasForeignKey(i => i.IntegradorId);

            modelBuilder.Entity<Grupo>()
                .HasMany(g => g.Integradores)
                .WithMany();*/
        }


    }
}

