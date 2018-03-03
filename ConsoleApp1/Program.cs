using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Constans.DBRepo;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string connectionStringAW =
          // @"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=AdventureWorks2014;Integrated Security=true";
          //  string connectionStringArek=
          //@"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=Arek;Integrated Security=true";
          //  using (SqlConnection con = new SqlConnection(connectionStringArek))
          //  {
          //      // select person 
          //     // var person = con.Query<Person>(Query.GetPerson_AdressFULL).AsEnumerable();


          //      var person_adress =
          //       con.Query<Person, Adres, Person >(Query.getPerson, (z, a) => {
          //           z.Adres = a;
          //           return z;

          //       }, splitOn: "IDA").ToList();




          //      foreach (var item in person_adress)
          //      {

          //          Console.WriteLine(item.Adres.City);
                  
          //      }

          //  }
            Console.ReadKey();
        }
    }
}
