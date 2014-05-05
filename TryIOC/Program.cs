using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IPersonRepository, PersonRepository>();
            container.RegisterType<IPersonService, PersonService>();

            var bll = container.Resolve<IPersonService>();
            var data = bll.GetItem(1);
            Console.WriteLine(data.Name);
            Console.ReadLine();
        }
    }
}
