using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_Exo.Data.Models;
using WPF_TP.Data.Models;

namespace GestImmoWPF.Data.DAL
{
    public class ImmoContext : DbContext
    {
        public DbSet<Contrat> Contrat { get; set; }
        public DbSet<Biens> Biens { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Pret> Prets { get; set; }
        public DbSet<Intervention>Interventions { get; set; }  
        public DbSet<Prestataire> Prestataires { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=GestImmo;Username=postgres;Password=Neox");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Habitations>().ToTable("Habitable");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Apparetement");
        }
        private static ImmoContext instace;

        public static ImmoContext getInstace()
        {
            if (instace == null)
            {
               instace = new ImmoContext();  
            }
            return instace;
            
        }
    }
}
