using System;
using OnlineHealthcareManagement.BL;
using OnlineHealthcareManagement.Entity;
namespace OnlineHealthcareManagementSystem
{
    public partial class SIGNUP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string mobileNumber = txtNumber.Text;
            string gender=txtGender.Text;
            DateTime DOB = Convert.ToDateTime(txtDOB.Text);
            string bloodGroup = txtBloodGroup.Text;
            string address = txtLocation.Text; 
            string EmailId = txtEmailID.Text;
            string password = txtPassword.Text;
            string confirmPassword =txtConfirmPassword.Text;
            PatientDetails patient = new PatientDetails(Name, gender, DOB, bloodGroup, mobileNumber, address, EmailId, password, confirmPassword);
            int rows = PatientBL.AddCustomer(patient);
            if (rows >= 1)
                Response.Redirect("Login.aspx");
            }
    
    }
}