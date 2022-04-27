using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class RegleInfoCompRepository : GenericRepository<RegleInfoComp>, IRegleInfoCompRepository
    {
        readonly Context _context;

        public RegleInfoCompRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
