using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entity;
using Dapper;
using Constans.DBRepo;

namespace DB.Repository
{
    public class PersonRepository : IPersonRepository
    {

          string connectionStringArek =@"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=Arek;Integrated Security=true";
        public IDbConnection Connection
        {
            get
            {
                return
                    new SqlConnection(connectionStringArek);
            }
        }
        void IRepository<Person>.Add(Person item)
        {
            throw new NotImplementedException();
        }

        void IRepository<Person>.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        Person IReadOnlyRepository<Person>.FindById(Guid id)
        {
            throw new NotImplementedException();
        }

       public Person FindByUserID(int personID)
        {
            var person = new Person();
            using (IDbConnection con = Connection)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var personQuery = con.Query<Person>(PersonQuery.getPersonByID, new { PersonID = personID }).FirstOrDefault();
                person = personQuery;
            }
            return person;
        }

        IEnumerable<Person> IReadOnlyRepository<Person>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Person>.Remove(Person item)
        {
            throw new NotImplementedException();
        }

        void IRepository<Person>.Update(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
