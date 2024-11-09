using EfCoreModelFirst.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreModelFirst.Veritabani
{
    public class BtkOkulDbContext : DbContext
    {
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localDb)\\mssqllocaldb;Database=" +
                "btk_okul_db;trusted_connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sinif>()
            .HasMany(e => e.Ogrenciler)
            .WithOne(e => e.Sinifi)
            .HasForeignKey(e => e.SinifId)
            .HasPrincipalKey(e => e.Id);
        }
    }
}
