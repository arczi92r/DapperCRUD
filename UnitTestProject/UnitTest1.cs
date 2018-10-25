
using ClassLibrary.Test;
using Xunit;

namespace UnitTestProject
{

    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            // Arange 
            int expected = 10;

     
            //Act
            Kalkulator k = new Kalkulator();
           int result =  k.Dodaj(5, 5);

            //Assert
            Assert.Equal(expected, result);
            Assert.Equal(3, 3);
        }
       
    }
}
