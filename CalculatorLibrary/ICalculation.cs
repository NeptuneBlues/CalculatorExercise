﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public interface ICalculation
    {
        public decimal Addition(int firstInput, int secondInput);
        public decimal Subtraction(int firstInput, int secondInput);
        public decimal Multiplication(int firstInput, int secondInput);
        public decimal Division(int firstInput, int secondInput);
    }
}
