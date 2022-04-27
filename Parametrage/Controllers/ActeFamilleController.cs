using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;
using Parametrage.Repositories;

namespace Parametrage.Controllers
{
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]/[action]")]
    public class ActeFamilleController : Controller
    {
        private IActeFamilleRepository repository = null;
        private IGenericRepository<Acte> ActeRepository = null;

        public ActeFamilleController(IActeFamilleRepository repository,
            IGenericRepository<Acte> ActeRepository)
        {
            this.repository = repository;
            this.ActeRepository = ActeRepository;
        }





        [HttpGet]
        public IEnumerable<ActeFamille> GetAll()
        {
            return repository.GetAll();

        }

        [HttpGet]
        public IEnumerable<ActeFamille> GetHierarchy()
        {
            return repository.GetHierarchy();

        }



        [HttpGet]
        public ActeFamille Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public int Add(Parametrage.Models.ActeFamilleModel model)
        {
            ActeFamille acteFamille = new ActeFamille()
            {
                Id = model.Id,
                Libelle = model.Libelle,
                Actes = new List<Acte>(),
                ActeFamilleId = model.acteFamille,
                acteFamilles = new List<ActeFamille>()

            };




            if (model.Actes != null)
            {
                foreach (var acte in model.Actes)
                {
                    acteFamille.Actes.Add(ActeRepository.GetById(acte));
                }
            }

            if (model.acteFamilles != null)
            {
                foreach (var acte in model.acteFamilles)
                {
                    acteFamille.acteFamilles.Add(repository.GetById(acte));
                }
            }

            repository.Insert(acteFamille);
            repository.Save();
            return acteFamille.Id;
        }

        [HttpPost]
        public string EditActeFamille(ActeFamille model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                repository.Save();
                return "OK";
            }
            else
            {
                return "KO";
            }
        }

        [HttpPost]
        public string Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
            return "OK";
        }
    }
}
