using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CalculatorPrototype.Models;

namespace CalculatorPrototype.Models
{
    public class CalculatorDBAccessLayer
    {
        SqlConnection con = new SqlConnection("Put your connection string here");
        public string AddNewCalculation(int firstInput, int secondInput, string operation, decimal result, string errorMessage)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Calculation_add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", 1);
                cmd.Parameters.AddWithValue("@FirstInput", firstInput);
                cmd.Parameters.AddWithValue("@SecondInput", secondInput);
                cmd.Parameters.AddWithValue("@Operator", operation);
                cmd.Parameters.AddWithValue("@Result", result);
                cmd.Parameters.AddWithValue("@ErrorMessage", errorMessage);
                cmd.Parameters.AddWithValue("@TimeStamp", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data Saved Successfully");
            }
            catch(Exception e)
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (e.Message.ToString());
            }
        }
    }
}
