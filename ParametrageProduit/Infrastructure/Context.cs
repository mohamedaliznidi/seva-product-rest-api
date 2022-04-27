using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;

namespace Parametrage.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
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
