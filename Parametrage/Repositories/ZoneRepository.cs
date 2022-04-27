using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        readonly Context _context;

        public ZoneRepository(Context context) : base(context)
        {
            _context = context;
        }

        
    }
}
