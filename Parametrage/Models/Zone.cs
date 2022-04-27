namespace Parametrage.Models
{
    public class Zone
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Pays> Pays { get; set; }
    }
}
