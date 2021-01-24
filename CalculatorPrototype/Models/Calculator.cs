using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorPrototype.Models
{
    public class Calculator
    {
        public int FirstInput { get; set; }
        public int SecondInput { get; set; }
        public decimal Result { get; set; }
        public int Operator { get; set; }
        public string ErrorMessage { get; set; }
    }
}
