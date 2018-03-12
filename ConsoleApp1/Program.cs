using System;
using System.Threading.Tasks;
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
           
               var a = RegisterContainer.Container.Resolve<IFiledsService>();

               var zzz = a.Get();
               

                Console.ReadKey();
           
        }
        public static void Init() {
            RegisterContainer.RegisterDependenciesServices();
        }
    }

    
}
