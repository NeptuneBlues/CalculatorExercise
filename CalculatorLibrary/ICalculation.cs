using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public interface ICalculation
    {
        public string ErrorMessage { get; set; }
        public decimal Result { get; set; }

        public void Addition(int firstInput, int secondInput);
        public void Subtraction(int firstInput, int secondInput);
        public void Multiplication(int firstInput, int secondInput);
        public void Division(int firstInput, int secondInput);
    }
}
