using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TypeCollegeController : Controller
    {
        private IGenericRepository<TypeCollege> repository = null;

        public TypeCollegeController(IGenericRepository<TypeCollege> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<TypeCollege> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public TypeCollege Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(TypeCollege model)
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
        public string EditTypeCollege(TypeCollege model)
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
