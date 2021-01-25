using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class CalculationFactory
    {
        public static ICalculation StartNewCalculation()
        {
            return new Calculator();
        }
    }
}
