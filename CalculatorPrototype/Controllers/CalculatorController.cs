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
        CalculatorDBAccessLayer _dbAccess { get; set; }

        public CalculatorController(ICalculation calc, CalculatorDBAccessLayer dbaccess)
        {
            _calculator = calc;
            _dbAccess = _dbAccess;
        }

        public IActionResult Index()
        {
            return View(_calculator);
        }


        [HttpPost]
        public IActionResult RunCalculation(int FirstInput, int SecondInput, int Operator)
        {
            switch(Operator) {
                case 0:
                    ViewData["Result"] = _calculator.Addition(FirstInput, SecondInput);
                    break;

                case 1:
                    ViewData["Result"] = _calculator.Subtraction(FirstInput, SecondInput);
                    break;

                case 2:
                    ViewData["Result"] = _calculator.Multiplication(FirstInput, SecondInput);
                    break;

                case 3:
                    try
                    {
                      ViewData["Result"] = _calculator.Division(FirstInput, SecondInput);
                    } catch(Exception e)
                    {
                        ViewData["Result"] = 0;
                        ViewData["Error"] = "Cannot Divide by 0";
                    }
                    break;
            }
            _dbAccess.AddNewCalculation(FirstInput, SecondInput, Operator.ToString(), (decimal)ViewData["Result"], ViewData["ErrorMessage"].ToString());

            return View("Index", _calculator);
        }
    }
}
