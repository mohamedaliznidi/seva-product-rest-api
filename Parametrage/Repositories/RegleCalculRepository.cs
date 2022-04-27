using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class RegleCalculRepository : GenericRepository<RegleCalcul>, IRegleCalculRepository
    {
        readonly Context _context;

        public RegleCalculRepository(Context context) : base(context)
        {
            _context = context;
        }

        public ICollection<Garantie> GetGaranties(string tc, int age, int zone)
        {
            return _context.RegleCalculs.Include(rc => rc.Garantie)
                .Where(rc => rc.Age == age && rc.ZoneId == zone && rc.TypeCotisant == tc).Select(rc => rc.Garantie).ToList();
        }

        public ICollection<Produit> GetProduits(string tc, int age, int zone)
        {
            return _context.RegleCalculs.Include(rc => rc.Garantie.SousProduit.Produit)
                .Where(rc => rc.Age == age && rc.ZoneId == zone && rc.TypeCotisant == tc).Select(rc => rc.Garantie.SousProduit.Produit).ToList();
        }


    }
}
