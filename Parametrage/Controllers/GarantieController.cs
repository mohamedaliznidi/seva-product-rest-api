using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]/[action]")]
    public class GarantieController : Controller
    {
        private IGenericRepository<Garantie> repository = null;
        private IGenericRepository<Risque> RisqueRepository = null;
        private IGenericRepository<Zone> ZoneRepository = null;

        public GarantieController(IGenericRepository<Garantie> repository,
            IGenericRepository<Risque> RisqueRepository,
            IGenericRepository<Zone> ZoneRepository)
        {
            this.repository = repository;
            this.RisqueRepository = RisqueRepository;
            this.ZoneRepository = ZoneRepository;
        }





        [HttpGet]
        public IEnumerable<Garantie> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Garantie Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public int Add(Parametrage.Models.GarantieModel model)
        {
            Garantie garantie = new Garantie()
            {
                Id = model.Id,
                Libelle = model.Libelle,
                LibelleCommercial = model.LibelleCommercial,
                DateEffet = model.DateEffet,
                Enseigne = model.Enseigne,
                GestionCotisation = model.GestionCotisation,
                GestionPrestation = model.GestionPrestation,
                Description = model.Description,
                Risques = new List<Risque>(),
                Zones = new List<Zone>(),
                IdDevise = model.IdDevise,
                SousProduitId = model.SousProduitId
            };


            if (model.Risques != null)
            {
                foreach (var r in model.Risques)
                {
                    garantie.Risques.Add(RisqueRepository.GetById(r));
                }
            }


            if (model.Zones != null)
            {
                foreach (var zone in model.Zones)
                {
                    garantie.Zones.Add(ZoneRepository.GetById(zone));
                }
            }

            repository.Insert(garantie);
            repository.Save();
            return garantie.Id;
        }

        [HttpPost]
        public string EditGarantie(Garantie model)
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
