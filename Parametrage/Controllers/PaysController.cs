using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PaysController : Controller
    {
        private IGenericRepository<Pays> repository = null;

        public PaysController(IGenericRepository<Pays> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Pays> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Pays Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Pays model)
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
        public string EditPays(Pays model)
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
