using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RegleInfoCompController : Controller
    {
        private IGenericRepository<RegleInfoComp> repository = null;

        public RegleInfoCompController(IGenericRepository<RegleInfoComp> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<RegleInfoComp> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public RegleInfoComp Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(RegleInfoComp model)
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
        public string EditRegleInfoComp(RegleInfoComp model)
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
