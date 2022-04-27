using Microsoft.EntityFrameworkCore;
using Parametrage.Entities;
using Parametrage.Infrastructure;
using Microsoft.EntityFrameworkCore.Proxies;

namespace Parametrage.Repositories
{
    public class ActeFamilleRepository : GenericRepository<ActeFamille>, IActeFamilleRepository
    {
        public Context _context;// { get; set; }

        public ActeFamilleRepository(Context context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<ActeFamille> GetHierarchy()
        {

            return _context.ActeFamilles.Include(af => af.acteFamilles).Where(af => af.acteFamille == null).Select(af => new ActeFamille
            {
                Id = af.Id,
                Libelle = af.Libelle,
                acteFamilles = af.acteFamilles,
                Actes = af.Actes
            });
        }
        public IEnumerable<ActeFamille> GetAll()
        {

            return _context.ActeFamilles.Select(af => new ActeFamille
            {
                Id = af.Id,
                Libelle = af.Libelle
            });
        }

        
    }
}
