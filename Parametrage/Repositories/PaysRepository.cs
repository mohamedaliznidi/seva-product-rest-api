using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class PaysRepository : GenericRepository<Pays>, IPaysRepository
    {
        readonly Context _context;

        public PaysRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
