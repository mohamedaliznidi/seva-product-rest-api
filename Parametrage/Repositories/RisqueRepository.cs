using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class RisqueRepository : GenericRepository<Risque>, IRisqueRepository
    {
        readonly Context _context;

        public RisqueRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
