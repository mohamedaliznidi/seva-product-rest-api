namespace Parametrage.Entities
{
    public class Pays
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public Devise Devise { get; set; }
        public ICollection<Zone> Zones { get; set; }
    }
}
