﻿using System;
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
        public IActionResult Index(Calculator calc, string operation)
        {
            switch(calc.Operator)
             {
                 case 0:
                     calc.Result = calc.FirstInput + calc.SecondInput;
                     break;

                 case 1:
                     calc.Result = calc.FirstInput - calc.SecondInput;
                     break;

                 case 2:
                     calc.Result = calc.FirstInput * calc.SecondInput;
                     break;

                 case 3:
                    try
                    {
                        calc.Result = Math.Round((decimal)calc.FirstInput / (decimal)calc.SecondInput, 3);
                    } catch(Exception e)
                    {
                        calc.Result = calc.Result;
                        calc.ErrorMessage = "Cannot Divide by 0";
                    }
                     break;
             }
            return View(calc);
        }
    }
}
