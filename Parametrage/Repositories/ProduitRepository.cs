using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class ProduitRepository : GenericRepository<Produit>, IProduitRepository
    {
        readonly Context _context;

        public ProduitRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
