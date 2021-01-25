using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : ICalculation
    {
        public string ErrorMessage { get; set; }
        public decimal Result { get; set; }


        public void Addition(int firstInput, int secondInput)
        {
            Result = (decimal)firstInput + (decimal)secondInput;
        }

        public void Subtraction(int firstInput, int secondInput)
        {
            Result = (decimal)firstInput - (decimal)secondInput;
        }

        public void Multiplication(int firstInput, int secondInput)
        {
            Result = (decimal)firstInput * (decimal)secondInput;
        }

        public void Division(int firstInput, int secondInput)
        {
            try
            {
                Result = Math.Round((decimal)firstInput / (decimal)secondInput, 3);
            }
            catch (Exception e)
            {
                Result = Result;
                ErrorMessage = "Cannot Divide by 0";
            }
        }
    }
}
