using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccessLayer
{
    public class PersonalInfo
    {
        #region Variable For Properties

        int personID;

        /*Basic Info*/
        string lastName;
        string firstName;
        string gender;
        DateTime birthday = DateTime.Now;
        string photopath;

        /*Address Info*/
        string address1;
        string address2;
        string city;
        string country; 

        /*Contact Info*/
        string phonenumber;
        string email;

        /*Education*/
        string highSchool;
        string college;
        string graduatedSchool;
        string major;
        DateTime startDate = DateTime.Now;
        DateTime endDate = DateTime.Now;


        /*Work*/
        string role;
        string industry;
        string company;
        string contractType;
        DateTime fromDate = DateTime.Now;
        DateTime toDate = DateTime.Now;

        #endregion


        #region Basic Info
        
        public int PersonID 
        {
            get { return personID; }
            set { personID = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string PhotoPath
        {
            get { return photopath; }
            set { photopath = value; }
        }
        #endregion


        #region Address Info

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        #endregion


        #region Contact Info

        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        #endregion


        #region Education

        public string HighSchool
        {
            get { return highSchool; }
            set { highSchool = value; }
        }

        public string College
        {
            get { return college; }
            set { college = value; }
        }

        public string GraduatedSchool
        {
            get { return graduatedSchool; }
            set { graduatedSchool = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate 
        {
            get { return endDate; }
            set { endDate = value; }
        }

        #endregion


        #region Work
  
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Industry
        {
            get { return industry; }
            set { industry = value;}
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string ContractType
        {
            get { return contractType; }
            set { contractType = value; }
        }
        public DateTime FromDate
        {
            get { return fromDate; }
            set { toDate = value; }
        }
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        #endregion
        
    }
}
