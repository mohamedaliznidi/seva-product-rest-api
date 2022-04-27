namespace Parametrage.Models
{
    public class ActeFamilleModel
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<int>? Actes { get; set; }
        public int? acteFamille { get; set; }
        public ICollection<int>? acteFamilles { get; set; }

    }
}
