using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryIOC
{
    public class DebugPersonRepository : IPersonRepository
    {
        public Person GetItem(int id)
        {
            return new Person { Name = "David", Age = 99 };
        }
    }
}
