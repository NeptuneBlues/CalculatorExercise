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
            ICalculation calculator = new Calculator();
            return View(calculator);
        }


        [HttpPost]
        public IActionResult RunCalculation(Calculator calc, int Operator)
        {
            switch(Operator) {
                case 0:
                    calc.Addition();
                    break;

                case 1:
                    calc.Subtraction();
                    break;

                case 2:
                    calc.Multiplication();
                    break;

                case 3:
                    calc.Division();
                    break;
            }

            return View("Index", calc);
        }
    }
}
