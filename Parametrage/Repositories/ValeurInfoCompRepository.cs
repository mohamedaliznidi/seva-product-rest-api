using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public class ValeurInfoCompRepository : GenericRepository<ValeurInfoComp>, IValeurInfoCompRepository
    {
        readonly Context _context;

        public ValeurInfoCompRepository(Context context) : base(context)
        {
            _context = context;
        }


    }
}
