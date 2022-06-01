using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.APP
{
    public class Calculator
    {

        private ICalculatorService _calculatorService;

        Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int Add(int a, int b)
        {
            return _calculatorService.add(a, b);
        }

        public int multip(int a, int b)
        {
            return _calculatorService.multip(a, b);
        }
    }
}
