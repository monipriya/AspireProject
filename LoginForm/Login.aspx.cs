using OnlineHealthcareManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineHealthcareManagementSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Button(object sender, EventArgs e)
        {

            string username = txtUserName.Text;
            string password = txtPassword.Text;
            bool isValid = PatientBL.ValidateLogin(username, password);
            if (isValid)
                Response.Write(" login Successful");
            else
                Response.Write("Login failed /n Enter the correct username and password");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SIGNUP.aspx");
        }
    }
}