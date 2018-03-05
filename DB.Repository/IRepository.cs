using System;

namespace DB.Repository
{
    public interface IRepository<T> : IReadOnlyRepository<T>
    {
         void  Add(T item);

        void Remove(T item);

        void Update(T item);

        void Delete(Guid id);
    }
}
