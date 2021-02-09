using Contracts;
using DAL.EntityFramework.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.EntityFramework
{
    public class CalculationRepository : IDBAccess
    {
        private readonly DataContext _context;

        public CalculationRepository(DataContext context)
        {
            _context = context;
        }
        public string AddNewCalculation(CalculationDto calculation)
        {
            var calculationEntity = new Calculation
            {
                Error = calculation.Error,
                FirstInput = calculation.FirstInput,
                SecondInput = calculation.SecondInput,
                Operator = calculation.Operator,
                Result = calculation.Result
            };

            _context.Calculations.Add(calculationEntity);
            _context.SaveChanges();

            return "Saved Successfully";
        }

        public IEnumerable<CalculationDto> GetCalculations(int max = 10)
        {
            return _context.Calculations.Take(max).Select(x =>
            
                new CalculationDto
                {
                    Error = x.Error,
                    FirstInput = x.FirstInput,
                    Operator = x.Operator,
                    Result = x.Result,
                    SecondInput = x.SecondInput
                }
            );
        }
    }
}
