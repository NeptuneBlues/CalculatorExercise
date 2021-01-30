using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CalculatorLibrary
{
    public interface IDBAccess
    {
        public string AddNewCalculation(int firstInput, int secondInput, string operation, ICalculation calc);
    }
}
