using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entity;
using Dapper;
using Constans.DBRepo;

namespace DB.Repository
{
    public class PersonRepository : IPersonRepository
    {

        string connectionStringArek =@"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=Arek;Integrated Security=true";
        public IDbConnection Connection = null;
        //    get
        //    {
        //        return
        //            new SqlConnection(connectionStringArek);
        //    }
        //}
        public PersonRepository(IDbConnection connection)
        {

            this.Connection = connection;
        }

        public void Add(Person item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Person FindById(Guid id)
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

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Person item)
        {
            throw new NotImplementedException();
        }

        public void Update(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
