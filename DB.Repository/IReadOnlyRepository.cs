using System;
using System.Collections.Generic;

namespace DB.Repository
{
    public interface IReadOnlyRepository<T>
    {
        T FindById(int id);

        IEnumerable<T> GetAll();
    }
}