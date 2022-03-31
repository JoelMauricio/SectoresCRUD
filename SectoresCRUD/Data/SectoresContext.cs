using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SectoresCRUD.Models;

namespace SectoresCRUD.Data
{
    public class SectoresContext : DbContext
    {
        public SectoresContext (DbContextOptions<SectoresContext> options)
            : base(options)
        {
        }

        public DbSet<SectoresCRUD.Models.Sector> Sectores { get; set; }
        public DbSet<SectoresCRUD.Models.Municipio> Municipios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SectoresCRUD.Models.Sector>().ToTable("Sector");
            modelBuilder.Entity<SectoresCRUD.Models.Municipio>().ToTable("Municipio");
        }
    }
}
