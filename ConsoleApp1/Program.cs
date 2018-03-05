using System;
using DB.Repository;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonRepository pr = new PersonRepository();
            
            Console.WriteLine(pr.FindByUserID(12).Name);
            Console.ReadKey();
           
        }
    }
}
