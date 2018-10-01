using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Constans.DBRepo;
using Dapper;
using Domain;

namespace DB.Repository
{
    public class RoleRepoDB : IRepository<Role>
    {

        
        public IConnectionFactory Connection = null;
        public RoleRepoDB(IConnectionFactory connection)
        {

            Connection = connection;
        }

        public void Add(Role item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Role item)
        {
            throw new NotImplementedException();
        }

        public void Update(Role item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Role FindById(int roleID)
        {
            var role = new Role();
            //using (IConnectionFactory con = Connection)
            //{
            //if (Connection.State == ConnectionState.Closed)
            //    con.Open();
           role = SqlMapper.Query<Role>(Connection.GetConnection , RoleQuery.GetRoleByID, new { Id = roleID }).FirstOrDefault();
           
                //role = con.Query<Role>(RoleQuery.GetRoleByID, new { Id = roleID }).FirstOrDefault();
                // var roleQuery = con.Query<Role>(RoleQuery.GetRoleByID, new { id = roleID }).FirstOrDefault();
                // person = personQuery;
            ///}
            return role;
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
