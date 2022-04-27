using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class CommissionnementRepository : GenericRepository<Commissionnement>, ICommissionnementRepository
    {
        readonly Context _context;

        public CommissionnementRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
