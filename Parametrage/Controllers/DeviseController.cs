using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DeviseController : Controller
    {
        private IGenericRepository<Devise> repository = null;

        public DeviseController(IGenericRepository<Devise> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Devise> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Devise Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Devise model)
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
        public string EditDevise(Devise model)
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
