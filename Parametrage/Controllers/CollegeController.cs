using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CollegeController : Controller
    {
        private IGenericRepository<College> repository = null;

        public CollegeController(IGenericRepository<College> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<College> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public College Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(College model)
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
        public string EditCollege(College model)
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
