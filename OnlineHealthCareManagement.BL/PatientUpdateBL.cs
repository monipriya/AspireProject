using System;
using OnlineHealthcareManagement.DAL;
using OnlineHealthcareManagement.Entity;
using System.Data;
namespace OnlineHealthcareManagement.BL
{
   public static class PatientUpdateBL
    {
        public static DataTable ShowPatientDetails()
        {
            return PatientRepository.ViewPackage();
        }
        public static void DeletePatientDetails(int id)
        {
            PatientRepository.DeletePatient( id);
        }
        public static void UpdatePatientDetails(string mailid,string number,string name,string id)
        {
            PatientRepository.UpdatePatient(mailid, number, name,id);
        }
        public static void InsertPatientDetails(PatientDetails patient)
        {
            PatientRepository.InsertPatient(patient);
        }
    }
}
