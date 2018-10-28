using Autofac;
using System.Reflection;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject
{

    public class IoCRegistrationTests
    {

        #region Configuration
        IContainer container;

       
        public IoCRegistrationTests()
        {
            var builder = new ContainerBuilder();

            var services = Assembly.Load("Service");
         


            builder.RegisterAssemblyTypes(services)
                   .Where(s => s.Name.EndsWith("Service")).AsImplementedInterfaces();
            container = builder.Build();

        }

        #endregion


        public void ContainerResolveAllTypess()
        {

            //Arrange
            // Test dla Bazy danych oraz test dla Repozytorium 
            var assembly = Assembly.Load("Service");
            var typesToResolve =  assembly.GetTypes().Where(t => t.Name.EndsWith("Service") && t.IsInterface);
            var typesObject = new List<object>();

            //Act                    
            foreach (var typeToResolve in typesToResolve)
            {
                typesObject.Add(container.Resolve(typeToResolve));

            }

            //Assert.Equal(2, typesObject.Count());
            //Assert
           // Assert.Equal(typesToResolve.Count(), typesObject.Count());
        }




    }
}
