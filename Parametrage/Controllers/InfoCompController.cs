﻿using Microsoft.AspNetCore.Mvc;
using Parametrage.Entities;
using Parametrage.Infrastructure;

namespace Parametrage.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class InfoCompController : Controller
    {
        private IGenericRepository<InfoComp> repository = null;

        public InfoCompController(IGenericRepository<InfoComp> repository)
        {
            this.repository = repository;
        }





        [HttpGet]
        public IEnumerable<InfoComp> GetAll()
        {
            return repository.GetAll();
            
        }



        [HttpGet]
        public InfoComp Find(int id)
        {
            return repository.GetById(id);
        }



        [HttpPost]
        public string Add(InfoComp model)
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
        public string EditInfoComp(InfoComp model)
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
