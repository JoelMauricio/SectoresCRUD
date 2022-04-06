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

        public DbSet<Sector> Sectores { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Ciudadano> Ciudadanos { get; set; }
        public DbSet<CiudadanoEstado> EstadosCiudadano { get; set; }
        public DbSet<ColegioElectoral> ColegiosElectorales { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Ocupacion> Ocupaciones { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<TipoDeSangre> TiposDeSangre { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudadano>().ToTable("Ciudadano");
            modelBuilder.Entity<CiudadanoEstado>().ToTable("CiudadanoEstado");
            modelBuilder.Entity<ColegioElectoral>().ToTable("ColegioElectoral");
            modelBuilder.Entity<EstadoCivil>().ToTable("EstadoCivil");
            modelBuilder.Entity<Municipio>().ToTable("Municipio");
            modelBuilder.Entity<Nacionalidad>().ToTable("Nacionalidad");
            modelBuilder.Entity<Ocupacion>().ToTable("Ocupacion");
            modelBuilder.Entity<Provincia>().ToTable("Provincia");
            modelBuilder.Entity<Sector>().ToTable("Sector");
            modelBuilder.Entity<TipoDeSangre>().ToTable("TipoDeSangre");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
    }

}
