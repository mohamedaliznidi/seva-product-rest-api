using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class SousProduitRepository : GenericRepository<SousProduit>, ISousProduitRepository
    {
        readonly Context _context;

        public SousProduitRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
