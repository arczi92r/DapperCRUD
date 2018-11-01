using Autofac;
using DataTransferObject;
using DB.Repository;
using Domain;
using Permission.Repositories;
using Repositories;
using Service;
using System.Reflection;

namespace Infrastructure
{
    public class RegisterContainer
    {
        public static IContainer Container { get; private set; }
        public static ContainerBuilder builder { get; set; }
        public static void RegisterDependenciesServices()
        {
            builder.RegisterType<FiledsService>().As<IFiledsService>().AsSelf();
            builder.RegisterType<RoleService>().As<IRoleService>().AsSelf();

        }
        public static void RegisterDependenciesRepository()
        {
            builder.RegisterType<FieldRepository>().As<IFieldRepository>().AsSelf();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().AsSelf();

        }
        public static void RegisterDependencies()
        {
            builder = new ContainerBuilder();

            //Register AutoMappers
            builder.Register(x => Mapper.AutoMapperConfig.Initialize()).AsSelf().SingleInstance();

            // Register DatabaseFactory
            builder.RegisterType<DBContext>().As<IConnectionFactory>().AsImplementedInterfaces().AsSelf().InstancePerLifetimeScope();


            builder.RegisterType<FieldRepoDB>().As<IRepository<Field>>().AsSelf();
            RegisterDependenciesRepository();
            RegisterDependenciesServices();
            Container = builder.Build();
        } 

        // Rejestrowanie zależnosći poprzez Refleksję , tylko sercvces
        public static void ReflectionRegisterTypes()
        {
            builder = new ContainerBuilder();
            builder.Register(x => Mapper.AutoMapperConfig.Initialize()).AsSelf().SingleInstance();

            // Register DatabaseFactory
            builder.RegisterType<DBContext>().As<IConnectionFactory>().AsImplementedInterfaces().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<FieldRepoDB>().As<IRepository<Field>>().AsSelf();
            var repository = Assembly.Load(" Permission.Repositories");
             // RegisterDependenciesRepository();
             // RegisterDependenciesServices();
             var services = Assembly.Load("Service");



            builder.RegisterAssemblyTypes(services)
                   .Where(s => s.Name.EndsWith("Service")).AsImplementedInterfaces();

            Container = builder.Build();
        }
    }
}
