using Domain;


namespace DB.Repository
{
    public interface IPersonRepository : IRepository<Field>
    {
        Field FindByUserID(int personID);
    }
}
