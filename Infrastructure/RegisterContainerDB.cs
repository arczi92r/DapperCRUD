using Autofac;
using DB.Repository;
using Domain;

namespace Infrastructure
{
    public class RegisterContainerDB
    {
        public ContainerBuilder _builder { get; set; }
        public RegisterContainerDB()
        {
            // _builder = builder;

        }
        public ContainerBuilder RegisterRepositoryDB(ContainerBuilder builder)
        {
          
            // _builder.RegisterType<DB.Repository.RoleRepository<Role>>().As<DB.Repository.IRoleRepository<Role>>().AsSelf();

            return builder;

        }
    }
}
