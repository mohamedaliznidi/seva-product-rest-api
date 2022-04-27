using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]/[action]")]
    public class ProduitController : Controller
    {
        private IGenericRepository<Produit> repository = null;
        private IGenericRepository<SousProduit> SPrepository = null;
        private IGenericRepository<Risque> RisqueRepository = null;
        private IGenericRepository<Zone> ZoneRepository = null;

        public ProduitController(IGenericRepository<Produit> repository,
            IGenericRepository<SousProduit> SPrepository,
            IGenericRepository<Risque> RisqueRepository,
            IGenericRepository<Zone> ZoneRepository)
        {
            this.repository = repository;
            this.SPrepository = SPrepository;
            this.RisqueRepository = RisqueRepository;
            this.ZoneRepository = ZoneRepository;
        }





        [HttpGet]
        public IEnumerable<Produit> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Produit Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public int Add(Parametrage.Models.ProduitModel model)
        {
            Produit produit = new Produit()
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
                SousProduits = new List<SousProduit>(),
                Risques = new List<Risque>(),
                Zones = new List<Zone>()
            };

            if (model.SousProduits != null)
            {
                foreach (var sp in model.SousProduits)
                {
                    produit.SousProduits.Add(SPrepository.GetById(sp));
                }
            }


            if (model.Risques != null)
            {
                foreach (var r in model.Risques)
                {
                    produit.Risques.Add(RisqueRepository.GetById(r));
                }
            }


            if (model.Zones != null)
            {
                foreach (var zone in model.Zones)
                {
                    produit.Zones.Add(ZoneRepository.GetById(zone));
                }
            }

            repository.Insert(produit);
            repository.Save();
            return produit.Id;
            
        }

        [HttpPost]
        public string EditProduit(Produit model)
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
