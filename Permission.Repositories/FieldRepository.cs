using DB.Repository;
using Domain;
using Repositories;

namespace Permission.Repositories
{
    public class FieldRepository : IFieldRepository
    {
        public readonly IRepository<Field> _repo;
        public FieldRepository(IRepository<Field> repo) //, IMapper mapper)
        {
            _repo = repo;
            //_mapper = mapper;
        }

        public Field GetFieldByID(int id)
        {
            return _repo.FindById(id);
        }
    }
}
