using Moq;
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
        public CalculatorTest(Calculator calculator, Mock<ICalculatorService> mymock)
        {
            this.calculator = calculator;
            this.mymock = mymock;
        }

        public Calculator calculator { get; set; }
        public Mock<ICalculatorService> mymock { get; set; }




        [Fact]
        public void AddTest()
        {
            //var calculator1 = new Calculator();   




        }


        [Theory]
        [InlineData(2, 5, 7)]
        public void Add_simpeValues_ReturnValue(int a, int b, int total)
        {
            mymock.Setup(x => x.add(a, b)).Returns(total);


            var actualTotal = calculator.Add(a, b);

            Assert.Equal(total, actualTotal);
        }



        [Theory]
        [InlineData(3, 5, 15)]
        public void Multip_SimpleValues_ReturnsMultipValue(int a, int b, int expectedValue)
        {
            mymock.Setup(x => x.multip(a, b)).Returns(expectedValue);
            Assert.Equal(12, calculator.multip(a, b));


        }
    }
}
