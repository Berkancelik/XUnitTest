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
            Assert.Single<int>(new List<int>() { 2, 3, 4 });
            Assert.Single(new List<string>() { "Berkan" });
,           

        }
    }
}
