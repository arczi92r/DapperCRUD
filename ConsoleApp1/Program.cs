using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
            //
           
        }
    }
}
