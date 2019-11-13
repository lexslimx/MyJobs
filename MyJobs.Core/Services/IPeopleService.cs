using MyJobs.Core.ViewModels;
using System.Collections.Generic;

namespace MyJobs.Core.Services
{
    public interface IPeopleService
    {
        List<PersonViewModel> GetPersons();
        void SavePerson(PersonViewModel newPerson);
    }
}