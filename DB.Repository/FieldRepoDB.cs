using System;
using System.Collections.Generic;
using System.Linq;
using Constans.DBRepo;
using Dapper;
using Domain;

namespace DB.Repository
{
    public class FieldRepoDB : IRepository<Field>
    {
        public IConnectionFactory Connection = null;
        public FieldRepoDB(IConnectionFactory connection)
        {

            this.Connection = connection;
        }

        public void Add(Field item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Field item)
        {
            throw new NotImplementedException();
        }

        public void Update(Field item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Field FindById(int id)
        {
            var field = new Field();
            field = SqlMapper.Query<Field>(Connection.GetConnection, RoleQuery.GetRoleByID, new { Id = id }).FirstOrDefault();
            return field;
        }

        public IEnumerable<Field> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
