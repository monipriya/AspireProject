using System;
namespace OnlineHealthcareManagement.Entity
{
   public class PatientDetails
    {
        public string name{ get; set; }
        public string sex { get; set; }
        public DateTime dob { get; set; }
        public string bloodGroup { get; set; }
        public string mobilenumber { get; set; }
        public string city { get; set; }
        public string mailId { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

        public PatientDetails( string name,string sex,DateTime dob,string bloodGroup,string mobilenumber,string city,string mailID,string password,string confirmPassword)
        {
            this.name =name;
            this.sex = sex;
            this.dob = dob;
            this.bloodGroup = bloodGroup;
            this.mobilenumber = mobilenumber;
            this.city = city;
            this.mailId = mailID;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

    }
}
