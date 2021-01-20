using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorPrototype.Models;

namespace CalculatorPrototype.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator calc, string number)
        {
            calc.firstInput = 1;
            return View(calc);
        }
    }
}
