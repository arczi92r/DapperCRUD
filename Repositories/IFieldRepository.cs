using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFieldRepository
    {
        IEnumerable<Field> GetAllFields();
        Task<IEnumerable<Field>> GetField(int id);
        Task<IEnumerable<Field>> GetField(string name);

    }
}
