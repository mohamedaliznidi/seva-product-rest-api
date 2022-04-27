using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CombinaisonController : Controller
    {
        private IGenericRepository<Combinaison> repository = null;

        public CombinaisonController(IGenericRepository<Combinaison> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Combinaison> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Combinaison Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Combinaison model)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(model);
                repository.Save();
                return "OK";
            }
            return "KO";
        }

        [HttpPost]
        public string EditCombinaison(Combinaison model)
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
