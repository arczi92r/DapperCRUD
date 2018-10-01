

using System.Data;
using System.Data.Common;

namespace DB.Repository
{
    public class DBContext : IConnectionFactory
    {
        string connectionStringArek = @"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=Arek;Integrated Security=true";

        public IDbConnection GetConnection
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionStringArek;
                conn.Open();
                return conn;
            }
        }

    }
}
