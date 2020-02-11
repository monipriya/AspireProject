using System;
using OnlineHealthcareManagement.DAL;
using OnlineHealthcareManagement.Entity;

namespace OnlineHealthcareManagement.BL
{
    public static class PatientBL
    {
        public static int AddCustomer(PatientDetails patient)
        {
            return Repositary.AddPatient(patient) ;
        } 
        public static bool ValidateLogin(string userName,string password)
        {
            return Repositary.ValidateLogin(userName, password);
        }
    }
}
