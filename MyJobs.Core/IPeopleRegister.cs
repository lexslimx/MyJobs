using System.Collections.Generic;

namespace MyJobs.Core
{
    public interface IPeopleRegister
    {
        List<PersonViewModel> GetPersons();
        void SavePerson(PersonViewModel newPerson);
    }
}