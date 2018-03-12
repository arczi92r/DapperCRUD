using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entity;
using Dapper;
using Constans.DBRepo;
using Domain;

namespace DB.Repository
{
    public class RoleRepository : IPersonRepository
    {

        string connectionStringArek =@"Data Source=ACER\MSSQLSERVER2016;Initial Catalog=Arek;Integrated Security=true";
        public IDbConnection Connection = null;
        public RoleRepository(IDbConnection connection)
        {

            this.Connection = connection;
        }

        public void Add(Role item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Role FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Role FindByUserID(int RoleID)
        {
            var role = new Role();
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
