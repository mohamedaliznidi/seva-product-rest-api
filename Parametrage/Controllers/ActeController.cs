using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;
using Parametrage.Models;

namespace Parametrage.Controllers
{
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]/[action]")]
    public class ActeController : Controller
    {
        private IGenericRepository<Acte> repository = null;

        public ActeController(IGenericRepository<Acte> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<Acte> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public Acte Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public int Add(ActeModel model)
        {
            Acte acte = new Acte()
            {
                Id = model.Id,
                Libelle = model.Libelle,
                ActeFamilleId = model.ActeFamilleId
            };
            repository.Insert(acte);
            repository.Save();
            return acte.Id;
        }

        [HttpPost]
        public string EditActe(Acte model)
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
