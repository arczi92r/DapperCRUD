using System;
using Autofac;
using Infrastructure;
using Service;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();

            var filedService = RegisterContainer.Container.Resolve<IFiledsService>();

            var zzz = filedService.GetField(1);
            Console.WriteLine(zzz.Name);

            //var roleServie = RegisterContainer.Container.Resolve<IRoleService>();
            //var result = roleServie.GetRole(1);

            Console.ReadKey();

        }
        public static void Init()
        {
            // RegisterContainer.RegisterDependencies();
            //Reflection, regiser All Service end wish service 
            RegisterContainer.ReflectionRegisterTypes();
        }
    }


}
