using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Parametrage.Entities;
using Parametrage.Infrastructure;
using Parametrage.Repositories;

namespace Parametrage.Controllers
{
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]/[action]")]
    public class RegleCalculController : Controller
    {
        private IRegleCalculRepository repository = null;

        public RegleCalculController(IRegleCalculRepository repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<RegleCalcul> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public RegleCalcul Find(int id)
        {
            return repository.GetById(id);
        }

        [HttpGet]
        public ICollection<Garantie> GetGaranties(string tc, int age, int zone)
        {
            return repository.GetGaranties(tc, age, zone);
        }

        [HttpGet]
        public ICollection<Produit> GetProduits(string tc, int age, int zone)
        {
            return repository.GetProduits(tc, age, zone);
        }



        [HttpPost]
        public int Add(Parametrage.Models.RegleCalculModel model)
        {
            RegleCalcul regleCalcul = new RegleCalcul()
            {
                Id = model.Id,
                Libelle = model.Libelle,
                Age = model.Age,
                ZoneId = model.Zone,
                TypeCotisant = model.TypeCotisant,
                RegleInfoComps = new List<RegleInfoComp>(),
                GarantieId = model.GarantieId,
            };



            repository.Insert(regleCalcul);
            repository.Save();
            return regleCalcul.Id;
        }

        [HttpPost]
        public string EditRegleCalcul(RegleCalcul model)
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
