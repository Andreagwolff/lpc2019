using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudEFCorePeopleVideoAula.Models;

namespace CrudEFCorePeopleVideoAula.Controllers
{
    public class PeopleController : Controller
    {
        private IPersonRepository repository;

        public PeopleController(IPersonRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var ListPeople = repository.GetAll();
            return View(ListPeople);
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            repository.Create(person);
            return RedirectToAction("Index");
        }
        public IActionResult Edit()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            repository.Update(person);
            return RedirectToAction("Index");
        }
         
        
        
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }


       
    }
}
