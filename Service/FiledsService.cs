using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObject;
using Repositories;

namespace Service
{
    public class FiledsService : IFiledsService
    {
        private readonly IFieldRepository _fieldRepository;
        private readonly IMapper _mapper;


        public FiledsService(IFieldRepository fieldRepository, IMapper mapper)
        {
            _fieldRepository = fieldRepository;
            _mapper = mapper;
        }

        public FiedDTO Get()
        {
            return new FiedDTO() { Name = "Are", Id = 10 };
        }
        public FiedDTO GetField(int id)
        {
            var a = _fieldRepository.GetFieldByID(id);
            var x = _mapper.Map<FiedDTO>(a);
            return x;
        }

        public Task<IEnumerable<FiedDTO>> GetField(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
