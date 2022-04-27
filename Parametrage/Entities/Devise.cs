using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Entities
{
    public class Devise
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public Pays? Pays { get; set; }
        [ForeignKey("Pays")]
        public int IdPays { get; set; }
    }
}
