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
    public partial class CreatePersonInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            PersonalInfo person = new PersonalInfo();
            person.LastName = txtLastName.Text;
            person.FirstName = txtFirstName.Text;
            person.Gender = txtGender.Text;
            person.Birthday =  DateTime.Parse(txtBirthday.Text);
            //person.PhotoPath = ;
            person.Address1 = txtAddress1.Text;
            person.Address2 = txtAddress2.Text;
            person.City = txtCity.Text;
            person.Country = txtCountry.Text;
            person.PhoneNumber = txtPhoneNumber.Text;
            person.Email = txtEmail.Text;
            person.College = txtCollege.Text;
            person.HighSchool = txtHighSchool.Text;
            person.GraduatedSchool = txtGraduatedSchool.Text;
            person.Major = txtMajor.Text;
            person.FromDate = DateTime.Parse(txtStartDate.Text);
            person.ToDate = DateTime.Parse(txtEndDate.Text);
            person.Role = txtRole.Text;
            person.Industry = txtIndustry.Text;
            person.Company = txtCompany.Text;
            person.ContractType = txtContractType.Text;
            person.FromDate = DateTime.Parse(txtFromDate.Text);
            person.ToDate = DateTime.Parse(txtToDate.Text);

            PersonalInfoHandler personHandler = new PersonalInfoHandler();
            if (personHandler.AddNewPersonalInfo(person) == true)
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