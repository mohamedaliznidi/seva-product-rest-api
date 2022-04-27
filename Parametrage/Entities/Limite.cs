namespace Parametrage.Entities
{
    public enum TypeLimite
    {
        montant,
        quantite,
        duree
    }
    public class Limite
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public TypeLimite TypeLimite { get; set; }
        public string Formule { get; set; }

    }
}
