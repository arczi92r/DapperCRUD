using DB.Repository;
using Domain;
using Repositories;

namespace Permission.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        public readonly IRepository<Role>  _repo;
       // private readonly IMapper _mapper;


        public RoleRepository(IRepository<Role> repo) //, IMapper mapper)
        {
            _repo = repo;
            //_mapper = mapper;
        }
        public Role GetRoleByID(int id) {
         return   _repo.FindById(id);
        }
    }
}
