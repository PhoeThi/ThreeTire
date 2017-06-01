using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusicLogicLayer;
using DataAccessLayer;

namespace PersonalInfoDemoNTire
{
    public partial class DeletePerson : System.Web.UI.Page
    {
        PersonalInfoHandler personaHandler = null;
        int PersonID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] as string;
            if (id == null)
            {
                Response.Redirect("ShowPersonInfo.aspx");
            }
            try
            {
                PersonID = Convert.ToInt32(id.Trim());
                personaHandler = new PersonalInfoHandler();
                PersonalInfo person = personaHandler.GetPersonDetails(PersonID);
                txtFirstName.Text = person.FirstName ;
                txtLastName.Text = person.LastName;
                txtGender.Text = person.Gender;
                txtBirthday.Text = person.Birthday.ToShortDateString();
                txtAddress1.Text = person.Address1;
                txtAddress2.Text = person.Address2;
                txtCity.Text = person.City;
                txtCountry.Text = person.Country;
                txtPhoneNumber.Text = person.PhoneNumber;
                txtEmail.Text = person.Email;
                txtHighSchool.Text = person.HighSchool;
                txtCollege.Text = person.College;
                txtGraduatedSchool.Text = person.GraduatedSchool;
                txtMajor.Text = person.Major;
                txtStartDate.Text = person.StartDate.ToShortDateString();
                txtEndDate.Text = person.EndDate.ToShortDateString();
                txtRole.Text = person.Role;
                txtIndustry.Text = person.Industry;
                txtCompany.Text = person.Company;
                txtContractType.Text = person.ContractType;
                txtFromDate.Text = person.FromDate.ToShortDateString();
                txtToDate.Text = person.ToDate.ToShortDateString();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            if (personaHandler.DeletePerson(PersonID))
            {
                Response.Redirect("ShowPersonInfo.aspx");
            }           
        }

        protected void btnNO_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowPersonInfo.aspx");
           
        }
    }
}