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
                    ViewData["Result"] = calc.Addition(FirstInput, SecondInput);
                    break;

                case 1:
                    ViewData["Result"] = calc.Subtraction(FirstInput, SecondInput);
                    break;

                case 2:
                    ViewData["Result"] = calc.Multiplication(FirstInput, SecondInput);
                    break;

                case 3:
                    try
                    {
                      ViewData["Result"] = calc.Division(FirstInput, SecondInput);
                    } catch(Exception e)
                    {
                        ViewData["Result"] = 0;
                        ViewData["Error"] = "Cannot Divide by 0";
                    }
                    break;
            }

            return View("Index", calc);
        }
    }
}
