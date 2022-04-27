namespace Parametrage.Entities
{
    public class Combinaison
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Garantie> Garanties { get; set; }
    }
}
