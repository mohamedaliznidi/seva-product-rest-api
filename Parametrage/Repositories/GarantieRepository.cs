using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class GarantieRepository : GenericRepository<Garantie>, IGarantieRepository
    {
        readonly Context _context;

        public GarantieRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
