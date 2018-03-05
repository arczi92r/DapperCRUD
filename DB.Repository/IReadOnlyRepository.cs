using System;
using System.Collections.Generic;

namespace DB.Repository
{
    public interface IReadOnlyRepository<T>
    {
        T FindById(Guid id);

        IEnumerable<T> GetAll();
    }
}