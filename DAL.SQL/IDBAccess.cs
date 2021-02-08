using System.Collections.Generic;
using DAL.SQL;
using Domain.Models;

namespace DAL.SQL
{
    public interface IDBAccess
    {
        string AddNewCalculation(CalculationDto calculation);

        IEnumerable<CalculationDto> GetCalculations(int max = 10);

    }
}
