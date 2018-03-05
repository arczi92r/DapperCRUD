using Entity;

namespace DB.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person FindByUserID(int personID);
    }
}
