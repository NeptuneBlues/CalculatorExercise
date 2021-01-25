using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : ICalculation
    {
        public int FirstInput { get; set; }
        public int SecondInput { get; set; }
        public string ErrorMessage { get; set; }
        public decimal Result { get; set; }


        public void Addition()
        {
            Result = (decimal)FirstInput + (decimal)SecondInput;
        }

        public void Subtraction()
        {
            Result = (decimal)FirstInput - (decimal)SecondInput;
        }

        public void Multiplication()
        {
            Result = (decimal)FirstInput * (decimal)SecondInput;
        }

        public void Division()
        {
            try
            {
                Result = Math.Round((decimal)FirstInput / (decimal)SecondInput, 3);
            }
            catch (Exception e)
            {
                Result = Result;
                ErrorMessage = "Cannot Divide by 0";
            }
        }
    }
}
