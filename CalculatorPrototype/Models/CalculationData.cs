using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorPrototype.Models
{
    public class CalculationData
    {
        public int FirstInput { get; set; }
        public int SecondInput { get; set; }
        public decimal Result { get; set; }
        public string Operator { get; set; }
        public string ErrorMessage { get; set; }
        public string TimeStamp { get; set; }
    }
}
