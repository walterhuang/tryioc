using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryIOC
{
    public class PersonRepository : TryIOC.IPersonRepository
    {
        public Person GetItem(int id)
        {
            return new Person { Id = 1, Name = "Walter", Age = 18 };
        }
    }
}
