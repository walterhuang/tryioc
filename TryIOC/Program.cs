using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
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

            //container.RegisterType<IPersonRepository, PersonRepository>();
            //container.RegisterType<IPersonService, PersonService>();

            // all-in-one
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);

            // injection constructor
            //container.RegisterType<IPersonRepository, PersonRepository>(new InjectionConstructor("test data source"));

            // register instance
            //container.RegisterInstance(typeof(IPersonRepository), new PersonRepository());

            // use config
            container.RegisterType<IPersonRepository, PersonRepository>("StandardRepository");
            container.RegisterType<IPersonRepository, DebugPersonRepository>("DebugRepository");

            var repositoryType = ConfigurationManager.AppSettings["RepositoryType"];
            container.RegisterType<IPersonService, PersonService>
                (new InjectionConstructor(container.Resolve<IPersonRepository>(repositoryType)));


            var bll = container.Resolve<IPersonService>();
            var data = bll.GetItem(1);
            Console.WriteLine(data.Name);
            Console.ReadLine();
        }
    }
}
