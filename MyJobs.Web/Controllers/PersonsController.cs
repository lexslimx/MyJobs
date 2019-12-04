using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyJobs.Core.Services;
using MyJobs.Core.ViewModels;

namespace MyJobs.Web.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPeopleService _peopleRegister;

        public PersonsController(IPeopleService peopleRegister)
        {
            _peopleRegister = peopleRegister;
        }

        // GET: Persons
        public ActionResult Index()
        {
            var persons = _peopleRegister.GetPersons();
            return View(persons);
        }

        // GET: Persons/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persons/Create
        public ActionResult Create()
        {
            PersonViewModel newPerson = new PersonViewModel();

            return View(newPerson);
        }

        // POST: Persons/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonViewModel newPerson)
        {
            try
            {                
                _peopleRegister.SavePerson(newPerson);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Persons/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persons/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
          throw new NotImplementedException();
        }

        // GET: Persons/Delete/5
        public ActionResult Delete(int id)
        {
           throw new NotImplementedException();
        }

        // POST: Persons/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
          throw new NotImplementedException();
        }
    }
}