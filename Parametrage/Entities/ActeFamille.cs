using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Entities
{
    public class ActeFamille
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Acte>? Actes { get; set; }

        public ActeFamille? acteFamille { get; set; }

        [ForeignKey("ActeFamille")]

        public int? ActeFamilleId { get; set; }
        public ICollection<ActeFamille>? acteFamilles { get; set; }

    }
}
