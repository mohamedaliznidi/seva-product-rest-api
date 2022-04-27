namespace Parametrage.Entities
{
    public class InfoComp
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<ValeurInfoComp>? ValeurInfoComps { get; set; }
    }
}
