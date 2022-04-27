using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]/[action]")]
    public class SousProduitController : Controller
    {
        private IGenericRepository<SousProduit> repository = null;
        private IGenericRepository<Risque> RisqueRepository = null;
        private IGenericRepository<Zone> ZoneRepository = null;

        public SousProduitController(IGenericRepository<SousProduit> repository,
            IGenericRepository<Risque> RisqueRepository,
            IGenericRepository<Zone> ZoneRepository)
        {
            this.repository = repository;
            this.RisqueRepository = RisqueRepository;
            this.ZoneRepository = ZoneRepository;
        }





        [HttpGet]
        public IEnumerable<SousProduit> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public SousProduit Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public int Add(Parametrage.Models.SousProduitModel model)
        {
            SousProduit sousProduit = new SousProduit()
            {
                Id = model.Id,
                Libelle = model.Libelle,
                LibelleCommercial = model.LibelleCommercial,
                DateEffet = model.DateEffet,
                Enseigne = model.Enseigne,
                GestionCotisation = model.GestionCotisation,
                GestionPrestation = model.GestionPrestation,
                IdDevise = model.IdDevise,
                Description = model.Description,
                Risques = new List<Risque>(),
                Zones = new List<Zone>(),
                Garanties = new List<Garantie>(),
                ProduitId = model.IdProduit
            };


            if (model.Risques != null)
            {
                foreach (var r in model.Risques)
                {
                    sousProduit.Risques.Add(RisqueRepository.GetById(r));
                }
            }


            if (model.Zones != null)
            {
                foreach (var zone in model.Zones)
                {
                    sousProduit.Zones.Add(ZoneRepository.GetById(zone));
                }
            }

            repository.Insert(sousProduit);
            repository.Save();
            return sousProduit.Id;

        }

        [HttpPost]
        public string EditSousProduit(SousProduit model)
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
