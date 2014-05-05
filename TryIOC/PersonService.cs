using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryIOC
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _repo;

        public PersonService(IPersonRepository repo)
        {
            _repo = repo;
        }

        public Person GetItem(int id)
        {
            return _repo.GetItem(id);
        }
    }
}
