
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace LoginForm
{
    public class Repositary
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      
        public int PatientData(string name,string gender,DateTime dob,string bloodGroup,string number,string location,string email, string password,string confirmPassword)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SP_Patient_ADD";
            int rows;
          
            using (SqlCommand sqlCommand = new SqlCommand(query,connection))
            {
                
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = name;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@sex";
                param.Value = gender;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DOB";
                param.Value = gender;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@bloodGroup";
                param.Value = bloodGroup;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mobileNumber";
                param.Value = number;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@city";
                param.Value = location;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mailId";
                param.Value = email;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = password;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@confirmPassword";
                param.Value = location;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);
                connection.Open();
                rows = sqlCommand.ExecuteNonQuery();
            }
            return rows;
        }
        public bool ValidateLogin(string username,string password)
        {
            bool isValue=false;
            SqlConnection connection =  new SqlConnection(connectionString);
            string query = "usp_Patient_Select";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@username";
                param.Value = username;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = password;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                connection.Open();
                SqlDataReader data;
                data = command.ExecuteReader();
                if (data.HasRows)
                    isValue = true; 
            }
                return isValue;
        }
    }
}