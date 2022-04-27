using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Entities
{
    public class SousProduit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string LibelleCommercial { get; set; }
        public DateTime DateEffet { get; set; }
        public string Enseigne { get; set; }
        public ICollection<Risque>? Risques { get; set; }
        public bool GestionPrestation { get; set; }
        public bool GestionCotisation { get; set; }
        public ICollection<Zone>? Zones { get; set; }
        public Devise? Devise { get; set; }
        [ForeignKey("Devise")]
        public int IdDevise { get; set; }
        public string Description { get; set; }
        public ICollection<Garantie>? Garanties { get; set; }
        public Produit Produit { get; set; }
        [ForeignKey("Produit")]
        public int? ProduitId { get; set; }
    }
}
 