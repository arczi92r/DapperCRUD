using System;
using System.Data;
using System.Data.SqlClient;
using DB.Repository;
using Infrastructure;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterContainer.RegisterDependenciesServices();



            Console.ReadKey();
           
        }
    }

    
}
