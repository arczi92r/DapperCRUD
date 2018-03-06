using System;
using System.Data;
using System.Data.SqlClient;
using DB.Repository;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionStringArek = @"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=Arek;Integrated Security=true";

            IDbConnection con = null;

            con = new SqlConnection(connectionStringArek);



            SqlConnection sql = Activator.CreateInstance<SqlConnection>();
            sql.ConnectionString = connectionStringArek;


            PersonRepository pr = new PersonRepository(sql);
            
            Console.WriteLine(pr.FindByUserID(12).Name);
            
            Console.ReadKey();
           
        }
    }
}
