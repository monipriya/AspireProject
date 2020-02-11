using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OnlineHealthcareManagement.Entity;
namespace OnlineHealthcareManagement.DAL
{
    public class Repositary
    {
      static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      public static int AddPatient(PatientDetails patient)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SP_Patient_ADD";
            int rows;

            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {

                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = patient.name;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@sex";
                param.Value = patient.sex;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DOB";
                param.Value =patient.dob;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@bloodGroup";
                param.Value =patient.bloodGroup;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mobileNumber";
                param.Value = patient.mobilenumber;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@city";
                param.Value =patient.city;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mailId";
                param.Value = patient.mailId;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value =patient. password;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@confirmPassword";
                param.Value = patient.confirmPassword;
                param.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(param);
                connection.Open();
                rows = sqlCommand.ExecuteNonQuery();
            }
            return rows;
        }
         public static bool ValidateLogin(string username,string password)
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