using System.ComponentModel.DataAnnotations.Schema;

namespace Parametrage.Entities
{
    public class RegleCalcul
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Age { get; set; }

        public Zone? Zone { get; set; }

        [ForeignKey("Devise")]

        public int ZoneId { get; set; }
        public string TypeCotisant { get; set; }
        public ICollection<RegleInfoComp> RegleInfoComps { get; set; }
        public Garantie? Garantie { get; set; }

        [ForeignKey("Garantie")]

        public int GarantieId { get; set; }

    }
}
