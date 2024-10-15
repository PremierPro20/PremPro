using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PremierPro.Models;

namespace PremierPro.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PremierPro.Models.Proizvod> Proizvod { get; set; } = default!;
        public DbSet<PremierPro.Models.Narudzba> Narudzba { get; set; } = default!;
        public DbSet<PremierPro.Models.ProizvodNarudzba> ProizvodNarudzba { get; set; } = default!;
        public DbSet<PremierPro.Models.ProdajaProizvoda> ProdajaProizvoda { get; set; } = default!;
        public DbSet<PremierPro.Models.Korpa> Korpa { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proizvod>().ToTable("Proizvod");
            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<ProizvodNarudzba>().ToTable("ProizvodNarudzba");
            modelBuilder.Entity<ProdajaProizvoda>().ToTable("ProdajaProizvoda");
            modelBuilder.Entity<Korpa>().ToTable("Korpa");

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");
            modelBuilder.Entity<ApplicationUser>().Property(e => e.FullName);
            modelBuilder.Entity<ApplicationUser>().Property(e => e.Id);
            modelBuilder.Entity<ApplicationUser>().Property(e => e.EmailAddress);
            modelBuilder.Entity<ApplicationUser>().Property(e => e.Password);
            modelBuilder.Entity<ApplicationUser>().Property(e => e.UserName);

            base.OnModelCreating(modelBuilder);
        }
    }
}
