using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Repositories;

namespace Permission.Repositories
{
    public class FieldRepository : IFieldRepository
    {
        public IEnumerable<Field> GetAllFields()
        {
            List<Field> aa = new List<Field>();
            aa.Add(new Field() { Name = "Arej", Id = 10 });


            return aa;
        }

        public Task<IEnumerable<Field>> GetField(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Field>> GetField(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
