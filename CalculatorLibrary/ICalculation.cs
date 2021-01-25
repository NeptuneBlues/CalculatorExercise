using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public interface ICalculation
    {
        public void Addition(int firstInput, int secondInput);
        public void Subtraction(int firstInput, int secondInput);
        public void Multiplication(int firstInput, int secondInput);
        public void Division(int firstInput, int secondInput);
    }
}
