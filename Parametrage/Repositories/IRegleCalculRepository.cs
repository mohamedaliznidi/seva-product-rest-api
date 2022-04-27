using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public interface IRegleCalculRepository : IGenericRepository<RegleCalcul>
    {
        public ICollection<Garantie> GetGaranties(string tc, int age, int zone);
        public ICollection<Produit> GetProduits(string tc, int age, int zone);

    }
}
