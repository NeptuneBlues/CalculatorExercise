using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : ICalculation
    {
        public decimal Result { get; set; }
        public string ErrorMessage { get; set; }


        public decimal Addition(int firstInput, int secondInput)
        {
            return (decimal)firstInput + (decimal)secondInput;
        }

        public decimal Subtraction(int firstInput, int secondInput)
        {
            return (decimal)firstInput - (decimal)secondInput;
        }

        public decimal Multiplication(int firstInput, int secondInput)
        {
            return (decimal)firstInput * (decimal)secondInput;
        }

        public decimal Division(int firstInput, int secondInput)
        {
            return Math.Round((decimal)firstInput / (decimal)secondInput, 3);
        }
    }
}
