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
    public partial class ShowPersonInfo : System.Web.UI.Page
    {
        PersonalInfoHandler personHandler = null;
        int PersonID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            personHandler = new PersonalInfoHandler();
            if (IsPostBack == false)
            {
                string id = Request.QueryString["id"] as string;
                if (id != null)
                {
                    PersonID = Convert.ToInt32(id.Trim());
                    GetPersonalInfoDetail(PersonID);
                }                
                BindDataGridView();               
            }           
            
    }

        private void BindDataGridView()
        {
            GridView1.DataSource = personHandler.GetPersonList();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreatePersonInfo.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetPersonalInfoDetail( int PersonID )
        {
            personHandler = new PersonalInfoHandler();
            PersonalInfo person = personHandler.GetPersonDetails(PersonID);

            txtAddress1.Text = person.Address1;
            txtAddress2.Text = person.Address2;

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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindDataGridView();
        }
    }
}