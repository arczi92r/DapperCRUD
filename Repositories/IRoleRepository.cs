using Domain;
using System;

namespace Repositories
{
    public interface IRoleRepository
    {
        Role GetRoleByID(int id);
    }
}
