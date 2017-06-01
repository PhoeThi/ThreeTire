using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusicLogicLayer;

namespace PersonalInfoDemoNTire
{
    public partial class UpdatePersonInfo : System.Web.UI.Page
    {
        PersonalInfoHandler personHandler = null;
        int PersonID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] as string;
            if (id == null)
            {
                Response.Redirect("ShowPersonInfo.aspx");
            }
            PersonID = Convert.ToInt32(id.Trim());
            if(!IsPostBack)
            {
                try
                {       
                    personHandler = new PersonalInfoHandler();
                    PersonalInfo person = personHandler.GetPersonDetails(PersonID);
                    person.PersonID = PersonID;
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
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            PersonalInfo person =  new PersonalInfo();
            person.PersonID = PersonID;
            person.LastName = txtLastName.Text;
            person.FirstName = txtFirstName.Text;
            person.Gender = txtGender.Text;
            person.Birthday = DateTime.Parse(txtBirthday.Text.ToString());
            person.Address1 = txtAddress1.Text;
            person.Address2 = txtAddress2.Text;
            person.City = txtCity.Text;
            person.Country = txtCountry.Text;
            person.PhoneNumber = txtPhoneNumber.Text;
            person.Email = txtEmail.Text;
            person.HighSchool = txtHighSchool.Text;
            person.College = txtCollege.Text;
            person.GraduatedSchool = txtGraduatedSchool.Text;
            person.Major = txtMajor.Text;
            person.StartDate = DateTime.Parse(txtStartDate.Text.ToString());
            person.EndDate = DateTime.Parse(txtEndDate.Text.ToString());
            person.Role = txtRole.Text;
            person.Industry = txtIndustry.Text;
            person.Company = txtCompany.Text;
            person.ContractType = txtContractType.Text;
            person.FromDate = DateTime.Parse(txtFromDate.Text.ToString());
            person.ToDate = DateTime.Parse(txtToDate.Text.ToString());

            PersonalInfoHandler personHandler = new PersonalInfoHandler();
            if (personHandler.UpdatePersonInfo(person) == true)
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