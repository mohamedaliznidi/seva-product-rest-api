using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class CollegeRepository : GenericRepository<College>, ICollegeRepository
    {
        readonly Context _context;

        public CollegeRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
