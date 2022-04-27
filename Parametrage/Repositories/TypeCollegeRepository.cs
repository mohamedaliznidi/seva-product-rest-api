using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class TypeCollegeRepository : GenericRepository<TypeCollege>, ITypeCollegeRepository
    {
        readonly Context _context;

        public TypeCollegeRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
