using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Repositories
{
    public interface IActeFamilleRepository : IGenericRepository<ActeFamille>
    {
        IEnumerable<ActeFamille> GetHierarchy();
    }
}
