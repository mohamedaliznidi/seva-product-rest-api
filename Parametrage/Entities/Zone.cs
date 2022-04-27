namespace Parametrage.Entities
{
    public class Zone
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Pays> Pays { get; set; }
        public ICollection<Garantie> Garanties { get; set; }
        public ICollection<Produit> Produits { get; set; }
        public ICollection<SousProduit> SousProduits { get; set; }
    }
}
