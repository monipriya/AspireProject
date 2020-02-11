using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineHealthcareManagement.BL;
using OnlineHealthcareManagement.Entity;
namespace OnlineHealthcareManagementSystem
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            DataTable table = PatientUpdateBL.ShowPatientDetails();
            PatientGridView.DataSource = table;
            PatientGridView.DataBind();
        }

        protected void PatientGridView_RowEditing(object sender, EventArgs e)
        {
            PatientGridView.EditIndex = -1;
            BindData();
        }
        protected void PatientRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(PatientGridView.DataKeys[e.RowIndex].Values["patientID"].ToString());
            PatientUpdateBL.DeletePatientDetails(userId);
            BindData();

        }
        protected void PatientGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e )
        {
            PatientGridView.EditIndex = -1;
            BindData();
        }
        protected void PatientRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox mailId = PatientGridView.Rows[e.RowIndex].FindControl("txtMail") as TextBox;
            string mail =mailId .Text;
            TextBox number = PatientGridView.Rows[e.RowIndex].FindControl("txtNumber") as TextBox;
            string contactNumber = number.Text;
            TextBox name = PatientGridView.Rows[e.RowIndex].FindControl("txtName") as TextBox;
            string patientName = name.Text;
            TextBox id =PatientGridView.Rows[e.RowIndex].FindControl("patientId") as TextBox;
            string patientValue = id.Text;
            int patient = Convert.ToInt16((patientValue.ToString()));
            PatientUpdateBL.UpdatePatientDetails(mail,contactNumber,patientName,patientValue);
            PatientGridView.EditIndex = -1;
            BindData();

        }
        protected void patient_Insert(object sender, EventArgs e)
        {
            TextBox name = (PatientGridView.FooterRow.FindControl("txtName") as TextBox);
            TextBox sex = (PatientGridView.FooterRow.FindControl("txtSex") as TextBox);
            TextBox mailId = (PatientGridView.FooterRow.FindControl("txtmail") as TextBox);
            TextBox dateOfBirth = PatientGridView.FooterRow.FindControl("txtdob") as TextBox;
            TextBox blood = PatientGridView.FooterRow.FindControl("txtBloodGroub") as TextBox;
            TextBox location = PatientGridView.FooterRow.FindControl("txtAddress") as TextBox;
            TextBox number = PatientGridView.FooterRow.FindControl("txtNumber") as TextBox;
            TextBox pattern = PatientGridView.FooterRow.FindControl("txtPassword") as TextBox;
            TextBox confirmCode = PatientGridView.FooterRow.FindControl("txtConfirmpassword") as TextBox;
            string patientName = name.Text;
            string patientMailId = mailId.Text;
            string dob = dateOfBirth.Text;
            string bloodGroup = blood.Text;
            string city = location.Text;
            string code = pattern.Text;
            DateTime patientSex =Convert.ToDateTime( sex.Text);
            string patientConfirmCode = confirmCode.Text;
            string mobileNumber = number.Text;
            int contact = Convert.ToInt32((mobileNumber).ToString());
            PatientDetails patient = new PatientDetails(patientName, dob, patientSex, bloodGroup, city, mobileNumber, code, patientConfirmCode, patientMailId);
            PatientUpdateBL.InsertPatientDetails(patient);
            BindData();
        }

        protected void CustomerGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}