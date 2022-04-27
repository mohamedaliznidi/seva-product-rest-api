using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Entities
{
    public class Produit
    {


        public Produit(Parametrage.Models.ProduitModel produit)
        {
            this.Id = produit.Id;
            this.Libelle = produit.Libelle;
            this.LibelleCommercial = produit.LibelleCommercial;
            this.DateEffet = produit.DateEffet;
            this.Enseigne = produit.Enseigne;
            this.GestionPrestation = produit.GestionPrestation;
            this.GestionCotisation = produit.GestionCotisation;
            this.IdDevise = produit.IdDevise;
            this.Description = produit.Description;
        }

        public Produit()
        {
               
        }


        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<SousProduit>? SousProduits { get; set; }
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
    }
}
