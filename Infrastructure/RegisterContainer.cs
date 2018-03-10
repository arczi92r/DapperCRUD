using Autofac;
using Service;

namespace Infrastructure
{
    public class RegisterContainer
    {
        public static IContainer Container { get; private set; }

        public static void RegisterDependenciesServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PersonService>();
            builder.RegisterModule()
            Container = builder.Build();
            //var user = Container.Resolve<Engine>();
            //user.Ahead(12);

        }
        public stat
    }
}
