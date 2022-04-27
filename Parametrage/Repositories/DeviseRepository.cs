using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class DeviseRepository : GenericRepository<Devise>, IDeviseRepository
    {
        readonly Context _context;

        public DeviseRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
