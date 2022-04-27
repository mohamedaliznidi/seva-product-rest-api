using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class InfoCompRepository : GenericRepository<InfoComp>, IInfoCompRepository
    {
        readonly Context _context;

        public InfoCompRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
