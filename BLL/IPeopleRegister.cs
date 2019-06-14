using System.Collections.Generic;

namespace BLL
{
    public interface IPeopleRegister
    {
        List<PersonViewModel> GetPersons();
        void SavePerson(PersonViewModel newPerson);
    }
}