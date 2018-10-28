using AutoMapper;
using DataTransferObject;
using Repositories;

namespace Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;


        public RoleService(IRoleRepository fieldRepository, IMapper mapper)
        {
            _roleRepository = fieldRepository;
            _mapper = mapper;
        }

        public RoleDTO GetRole(int id)
        {
            var result =  _roleRepository.GetRoleByID(id);
            var x = _mapper.Map<RoleDTO>(result);
            return x;
        }
    }
}
