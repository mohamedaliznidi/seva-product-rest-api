using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ValeurInfoCompController : Controller
    {
        private IGenericRepository<ValeurInfoComp> repository = null;

        public ValeurInfoCompController(IGenericRepository<ValeurInfoComp> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<ValeurInfoComp> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public ValeurInfoComp Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(ValeurInfoComp model)
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
        public string EditValeurInfoComp(ValeurInfoComp model)
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
