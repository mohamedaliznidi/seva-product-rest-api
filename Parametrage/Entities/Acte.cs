using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Entities
{
    public class Acte
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ActeFamille? ActeFamille { get; set; }

        [ForeignKey("ActeFamille")]

        public int? ActeFamilleId { get; set; }


        public Acte()
        {

        }
    }
}
