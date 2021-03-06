using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ZoneController : Controller
    {
        private IGenericRepository<Zone> repository = null;

        public ZoneController(IGenericRepository<Zone> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Zone> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Zone Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(Zone model)
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
        public string EditZone(Zone model)
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
