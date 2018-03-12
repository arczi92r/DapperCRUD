using DataTransferObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public interface IFiledsService
    {
        Task<IEnumerable<FiedDTO>>  GetAllFields();
        Task<IEnumerable<FiedDTO>> GetField(int id);
        Task<IEnumerable<FiedDTO>> GetField(string name);
        FiedDTO Get();
    }
}
