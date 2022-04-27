namespace Parametrage.Models
{
    public class Risque
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<ProduitModel>? Produits { get; set; }
        public ICollection<SousProduit>? SousProduits { get; set; }
        public ICollection<Garantie>? Garanties { get; set; }

    }
}
