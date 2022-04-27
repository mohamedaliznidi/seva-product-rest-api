using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class IntervenantRepository : GenericRepository<Intervenant>, IIntervenantRepository
    {
        readonly Context _context;

        public IntervenantRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
