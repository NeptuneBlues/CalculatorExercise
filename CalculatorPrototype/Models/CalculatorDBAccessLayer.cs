using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CalculatorPrototype.Models;
using CalculatorLibrary;

namespace CalculatorPrototype.Models
{
    public class CalculatorDBAccessLayer
    {
        SqlConnection con = new SqlConnection("Data Source=Dev-SDJ;Initial Catalog=CalculatorPrototype;Persist Security Info=True;User ID=JB_ExerciseUser;Password=Exercise179181!?!");
        public string AddNewCalculation(int firstInput, int secondInput, string operation, ICalculation calc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Calculation_add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", 1);
                cmd.Parameters.AddWithValue("@FirstInput", firstInput);
                cmd.Parameters.AddWithValue("@SecondInput", secondInput);
                cmd.Parameters.AddWithValue("@Operator", operation);
                cmd.Parameters.AddWithValue("@Result", calc.Result);
                cmd.Parameters.AddWithValue("@ErrorMessage", calc.ErrorMessage);
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
