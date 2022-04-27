using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class ActeRepository : GenericRepository<Acte>, IActeRepository
    {
        readonly Context _context;

        public ActeRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
