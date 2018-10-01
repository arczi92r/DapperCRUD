using System.Data;

namespace DB.Repository
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}