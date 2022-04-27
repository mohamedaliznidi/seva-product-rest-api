using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class LimiteRepository : GenericRepository<Limite>, ILimiteRepository
    {
        readonly Context _context;

        public LimiteRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
