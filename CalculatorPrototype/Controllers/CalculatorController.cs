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
        public IActionResult RunCalculation(Calculator calc)
        {
            calc.Calculate();
            return View("Index", calc);
        }
    }
}
