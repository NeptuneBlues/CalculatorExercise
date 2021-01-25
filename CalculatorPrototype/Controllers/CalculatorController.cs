using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorPrototype.Models;
using CalculatorLibrary;

namespace CalculatorPrototype.Controllers
{
    public class CalculatorController : Controller
    {
        ICalculation _calculator { get; set; }

        public CalculatorController(ICalculation calc)
        {
            _calculator = calc;
        }

        public IActionResult Index()
        {
            return View(_calculator);
        }


        [HttpPost]
        public IActionResult RunCalculation(Calculator calc, int FirstInput, int SecondInput, int Operator)
        {
            switch(Operator) {
                case 0:
                    calc.Addition(FirstInput, SecondInput);
                    break;

                case 1:
                    calc.Subtraction(FirstInput, SecondInput);
                    break;

                case 2:
                    calc.Multiplication(FirstInput, SecondInput);
                    break;

                case 3:
                    calc.Division(FirstInput, SecondInput);
                    break;
            }

            return View("Index", calc);
        }
    }
}
