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
            Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());

            Assert.IsAssignableFrom<Object>(2);


        }
    }
}
