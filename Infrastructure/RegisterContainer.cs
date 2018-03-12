using Autofac;
using Permission.Repositories;
using Repositories;
using Service;

namespace Infrastructure
{
    public class RegisterContainer
    {
        public static IContainer Container { get; private set; }

        public static void RegisterDependenciesServices()
        {
            var builder = new ContainerBuilder();
            builder.Register(x => Mapper.AutoMapperConfig.Initialize()).AsSelf().SingleInstance();
            builder.RegisterType<FieldRepository>().As<IFieldRepository>().AsSelf();
            builder.RegisterType<FiledsService>().As<IFiledsService>().AsSelf();
           

            Container = builder.Build();
            //var user = Container.Resolve<Engine>();
            //user.Ahead(12);

        }
        //private static void RegisterServices(this ContainerBuilder builder)
        //{
            

        //}
    }
}
