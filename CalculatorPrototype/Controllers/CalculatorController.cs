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
        ICalculation Calculator { get; set; }

        public CalculatorController()
        {
            Calculator = new Calculator();
        }

        public IActionResult Index()
        {
            return View(Calculator);
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            calc.Calculate();
            return View(calc);
        }
    }
}
