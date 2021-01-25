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
        public decimal Result { get; set; }
        public int Operator { get; set; }
        public string ErrorMessage { get; set; }

        public void Calculate()
        {
            switch (Operator)
            {
                case 0:
                    Result = FirstInput + SecondInput;
                    break;

                case 1:
                    Result = FirstInput - SecondInput;
                    break;

                case 2:
                    Result = FirstInput * SecondInput;
                    break;

                case 3:
                    try
                    {
                        Result = Math.Round((decimal)FirstInput / (decimal)SecondInput, 3);
                    }
                    catch (Exception e)
                    {
                        Result = Result;
                        ErrorMessage = "Cannot Divide by 0";
                    }
                    break;
            }
        }
    }
}
