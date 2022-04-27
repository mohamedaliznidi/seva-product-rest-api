namespace Parametrage.Models
{
    public class RegleCalculModel
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Age { get; set; }
        public int Zone { get; set; }
        public string TypeCotisant { get; set; }
        public ICollection<int>? RegleInfoComps { get; set; }

        public int GarantieId { get; set; }

    }
}
