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
            Assert.StartsWith("Bir", "Bir masal");
            Assert.EndsWith("masal, "Bir masal");

        }
    }
}
