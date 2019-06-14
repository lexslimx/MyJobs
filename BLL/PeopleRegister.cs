using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class PeopleRegister : IPeopleRegister
    {
        private readonly MyJobsContext _db;

        public PeopleRegister(MyJobsContext db)
        {
            _db = db;
        }

        public List<PersonViewModel> GetPersons()
        {
            var results = new List<PersonViewModel>();
            var people = _db.Persons;

            foreach (var item in people)
            {
                results.Add(new PersonViewModel
                {
                    FirstName = item.FirstName,
                    Address = item.Address
                });
            }

            return results;
        }

        public void EditPerson()
        {
            var p = _db.Persons.Find(1);

            p.FirstName = "p1";

            p.Jobs.Add(new Job { Title = "first Job" });

            _db.SaveChanges();
        }

        public void SavePerson(PersonViewModel newPerson)
        {
            Person person = new Person();
            person.FirstName = newPerson.FirstName;
            person.Address = newPerson.Address;

            Job defaultJob = new Job
            {
                Title = "Unemployed",
                Salary = 200
            };

            person.Jobs.Add(defaultJob);

            _db.Persons.Add(person);

            _db.SaveChanges();
        }
    }

    public class PersonViewModel
    {
        public string FirstName { get; set; }
        public string Address { get; set; }
    }

    public class JobViewModel
    {
        public string Title { get; set; }
        public double Salary { get; set; }
    }
}