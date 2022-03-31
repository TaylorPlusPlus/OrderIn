using System;
using Xunit;
using OrderIn.Domain.Models;

namespace OrderIn.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Calamari app = new Calamari();
            double[] expected = new double[] {1,1,3,5,9};
            double[] param = new double[]{1,1,3};
            double[] actual;
            //Act  
            actual = app.Tribonacci(param, 5);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
