using System;
namespace AutoFacTest
{
    public class UserRepository : IUserRepository
    {
        public void Write()
        {
            Console.WriteLine("Runn");
        }
    }
}
