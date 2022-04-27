using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class IntervenantController : Controller
    {
        private IGenericRepository<Intervenant> repository = null;

        public IntervenantController(IGenericRepository<Intervenant> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Intervenant> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Intervenant Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Intervenant model)
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
        public string EditIntervenant(Intervenant model)
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
