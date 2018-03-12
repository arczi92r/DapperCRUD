using System.Collections.Generic;
using System.Threading;
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

        public Task<IEnumerable<FiedDTO>> GetAllFields()
        {
            //var a = _fieldRepository.GetAllFields();

            //return _mapper.Map<IEnumerable<FiedDTO>>(a);
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<FiedDTO>> GetField(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<FiedDTO>> GetField(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
