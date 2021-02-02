using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorPrototype.Models;
using CalculatorLibrary;
using DAL.SQL;

namespace CalculatorPrototype.Controllers
{
    public class CalculatorController : Controller
    {
        ICalculation _calculator { get; set; }
        IDBAccess _dbAccess { get; set; }

        public CalculatorController(ICalculation calc, IDBAccess accessor)
        {
            _calculator = calc;
            _dbAccess = accessor;
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
                    calc.Result = _calculator.Addition(FirstInput, SecondInput);
                    break;

                case 1:
                    calc.Result = _calculator.Subtraction(FirstInput, SecondInput);
                    break;

                case 2:
                    calc.Result = _calculator.Multiplication(FirstInput, SecondInput);
                    break;

                case 3:
                    try
                    {
                        calc.Result = _calculator.Division(FirstInput, SecondInput);
                    } catch(Exception e)
                    {
                        calc.Result = 0;
                        calc.ErrorMessage = "Cannot Divide by 0";
                    }
                    break;
            }
            _dbAccess.AddNewCalculation(FirstInput, SecondInput, Operator.ToString(), calc.Result, calc.ErrorMessage);

            return View("Index", calc);
        }

        [HttpGet]
        public IActionResult GetPastCalculations(int max = 10)
        {
            var result = _dbAccess.GetCalculations(max);
            return View(result);
            throw new NotImplementedException();
        }
    }
}