using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;

namespace Parametrage.Infrastructure
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActeFamille>().Navigation(af => af.Actes).AutoInclude();
            modelBuilder.Entity<RegleCalcul>().Navigation(af => af.Zone).AutoInclude();


            
            modelBuilder.Entity<SousProduit>()
                .HasOne(s => s.Produit)
                .WithMany(p => p.SousProduits)
                .OnDelete(DeleteBehavior.Cascade);
        }



        public DbSet<Acte> Actes { get; set; }
        public DbSet<ActeFamille> ActeFamilles { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Commissionnement> Commissionnements { get; set; }
        public DbSet<Garantie> Garanties { get; set; }
        public DbSet<Intervenant> Intervenants { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<RegleCalcul> RegleCalculs { get; set; }
        public DbSet<Risque> Risques { get; set; }
        public DbSet<SousProduit> SousProduits { get; set; }
        public DbSet<TypeCollege> TypeColleges { get; set; }
        public DbSet<Zone> Zones { get; set; }
    }
}
