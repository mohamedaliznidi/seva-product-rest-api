using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommissionnementController : Controller
    {
        private IGenericRepository<Commissionnement> repository = null;

        public CommissionnementController(IGenericRepository<Commissionnement> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Commissionnement> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Commissionnement Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Commissionnement model)
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
        public string EditCommissionnement(Commissionnement model)
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
