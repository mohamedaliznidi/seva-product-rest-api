using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LimiteController : Controller
    {
        private IGenericRepository<Limite> repository = null;

        public LimiteController(IGenericRepository<Limite> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Limite> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Limite Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Limite model)
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
        public string EditLimite(Limite model)
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
