using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class CombinaisonRepository : GenericRepository<Combinaison>, ICombinaisonRepository
    {
        readonly Context _context;

        public CombinaisonRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
