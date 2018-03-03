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
            string connectionString =
           @"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=AdventureWorks2014;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // select person 
                var person = con.Query<Person>(Query.GetPerson_AdressFULL).AsEnumerable();


                var person_adress =
                 con.Query<Person, BusinessEntity, Person >(Query.GetPerson_AdressFULL, (p, businessEntity) => {
                     p.BusinessEntitya = businessEntity;
                     return p;

                 }, commandType: CommandType.Text, splitOn: "be.BusinessEntityID").ToList();




                foreach (var item in person)
                {

                    Console.WriteLine(item.FirstName);
                    Console.WriteLine(item.BusinessEntitya.ModifiedDate);

                }

            }
            Console.ReadKey();
        }
    }
}
