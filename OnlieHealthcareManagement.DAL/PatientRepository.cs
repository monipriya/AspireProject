using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OnlineHealthcareManagement.Entity;

namespace OnlineHealthcareManagement.DAL
{
    public static class PatientRepository
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        static SqlConnection connection = null;
        public static DataTable ViewPackage()
        {
            string procedure = "sp_View_PatientDetails";
            DataTable table;
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                connection.Open();
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            return table;
        }
        public static void DeletePatient(int userId)
        {
            string procedure = "sp_Delete_PatientDetails";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@USERID", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdatePatient(string mailId,string mobileNumber,string name,string userId)
        {
            string procedure = "sp_Patient_Update";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name",name );
                command.Parameters.AddWithValue("@mailid",mailId);
                command.Parameters.AddWithValue("@mobileNumber",mobileNumber);
                command.Parameters.AddWithValue("@USERID",userId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void InsertPatient(PatientDetails patient)
        {
            string procedure = "usp_Patient_Add";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name",patient.name);
                command.Parameters.AddWithValue("@sex", patient.sex);
                command.Parameters.AddWithValue("@dob", patient.dob);
                command.Parameters.AddWithValue("@bloodGroup", patient.bloodGroup);
                command.Parameters.AddWithValue("@mobileNumber", patient.mobilenumber);
                command.Parameters.AddWithValue("@mailId", patient.mailId);
                command.Parameters.AddWithValue("@city", patient.city);
                command.Parameters.AddWithValue("@password", patient.password);
                command.Parameters.AddWithValue("@confirmPassword", patient.confirmPassword);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }



    }
}
