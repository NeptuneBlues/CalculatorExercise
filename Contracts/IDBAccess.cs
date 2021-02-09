using System.Collections.Generic;
using Domain.Models;

namespace Contracts
{
    public interface IDBAccess
    {
        string AddNewCalculation(CalculationDto calculation);

        IEnumerable<CalculationDto> GetCalculations(int max = 10);

    }
}
