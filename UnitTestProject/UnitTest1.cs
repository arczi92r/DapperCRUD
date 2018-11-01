
using ClassLibrary.Test;
using Xunit;

namespace UnitTestProject
{

    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
        
            // Napisać test z połaczenim z bazą danych
       
            // Arange 
            IoCRegistrationTests a = new IoCRegistrationTests();
            a.ContainerResolveAllTypess();
        }
       
    }
}
