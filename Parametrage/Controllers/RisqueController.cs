using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RisqueController : Controller
    {
        private IGenericRepository<Risque> repository = null;

        public RisqueController(IGenericRepository<Risque> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Risque> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Risque Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Risque model)
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
        public string EditRisque(Risque model)
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
