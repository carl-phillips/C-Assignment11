using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public class PersonService
    {
        private PersonContext _personContext;

        public PersonService(PersonContext personContext)
        {
            _personContext = personContext;
        }

        public bool DoesPersonExist(int id)
        {
            var person = _personContext.Persons.Find(id);

            if (person == null)
            {
                return false;
            }

            return true;
        }
    }
}
