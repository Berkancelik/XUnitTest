using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test
{
    public  class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            Assert.True(5 > 20);
            Assert.True(5 > 2);
            Assert.False(5 > 20);



            Assert.True("".GetType()==typeof(string));

        }
    }
}
