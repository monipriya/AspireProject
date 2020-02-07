using System;

namespace LoginForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login_BUtton(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            Repositary user = new Repositary();
            bool isValid=user.ValidateLogin(username, password);
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