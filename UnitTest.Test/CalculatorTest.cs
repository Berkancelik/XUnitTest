using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            var calculator = new Calculator();   

            


        }


        [Theory]
        [InlineData(2,5,7)]
        public void AddTest2(int a, int b, int total)
        {
            var calculator = new Calculator();

            var actualTotal = calculator.Add(a, b);

            Assert.Equal(total, actualTotal);
        }
    }
}
