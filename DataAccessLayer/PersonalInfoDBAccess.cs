using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class PersonalInfoDBAccess
    {
        public bool AddNewPersonalInfo(PersonalInfo person)
        {
            SqlParameter[] paramenters = new SqlParameter[]
            {
                new SqlParameter("@LastName",person.LastName),
                new SqlParameter("@FirstName",person.FirstName),
                new SqlParameter("@Gender",person.Gender),
                new SqlParameter("@BirthDay",person.Birthday),
                //new SqlParameter("@PhotoPath",person.PhotoPath),

                new SqlParameter("@Address1",person.Address1),
                new SqlParameter("@Address2",person.Address2),
                new SqlParameter("@City",person.City),
                new SqlParameter("@Country",person.Country),

                new SqlParameter("@PhoneNumber",person.PhoneNumber),
                new SqlParameter("@Email",person.Email),

                new SqlParameter("@HighSchool",person.HighSchool),
                new SqlParameter("@College",person.College),
                new SqlParameter("@GraduatedSchool",person.GraduatedSchool),
                new SqlParameter("@Major",person.Major),
                new SqlParameter("@StartDate",person.StartDate),
                new SqlParameter("@EndDate",person.EndDate),

                new SqlParameter("@Role",person.Role),
                new SqlParameter("@Industry",person.Industry),
                new SqlParameter("@Company",person.Company),
                new SqlParameter("@ContractType",person.ContractType),
                new SqlParameter("@FromDate",person.FromDate),
                new SqlParameter("@ToDate",person.ToDate),
                
            };
            return DBConnection.ExecureNoneQuery("AddNewPersonalInfo",CommandType.StoredProcedure,paramenters);
        }

        public bool UpdatePersonInfo(PersonalInfo person)
        {
            SqlParameter[] paramenters = new SqlParameter[]
            {
                new SqlParameter("@PersonID",person.PersonID),
                new SqlParameter("@LastName",person.LastName),
                new SqlParameter("@FirstName",person.FirstName),
                new SqlParameter("@Gender",person.Gender),
                new SqlParameter("@BirthDay",person.Birthday),
                //new SqlParameter("@PhotoPath",person.PhotoPath),

                new SqlParameter("@Address1",person.Address1),
                new SqlParameter("@Address2",person.Address2),
                new SqlParameter("@City",person.City),
                new SqlParameter("@Country",person.Country),

                new SqlParameter("@PhoneNumber",person.PhoneNumber),
                new SqlParameter("@Email",person.Email),

                new SqlParameter("@HighSchool",person.HighSchool),
                new SqlParameter("@College",person.College),
                new SqlParameter("@GraduatedSchool",person.GraduatedSchool),
                new SqlParameter("@Major",person.Major),
                new SqlParameter("@StartDate",person.StartDate),
                new SqlParameter("@EndDate",person.EndDate),

                new SqlParameter("@Role",person.Role),
                new SqlParameter("@Industry",person.Industry),
                new SqlParameter("@Company",person.Company),
                new SqlParameter("@ContractType",person.ContractType),
                new SqlParameter("@FromDate",person.FromDate),
                new SqlParameter("@ToDate",person.ToDate),
            };
            return DBConnection.ExecureNoneQuery("UpdatePersonInfo", CommandType.StoredProcedure, paramenters);
        }

        public bool DeletePeronInfo(int personID)
        {
            SqlParameter[] paramenter = new SqlParameter[]
            {
                new SqlParameter("@PersonID",personID)
            };
            return DBConnection.ExecureNoneQuery("DeletePerson", CommandType.StoredProcedure, paramenter);
        }

        public List<PersonalInfo> GetPersonList()
        {
            List<PersonalInfo> ListPerson = null;
            SqlParameter[] paramenter = new SqlParameter[]
            {
                new SqlParameter("@PersonID","")
            };
            using (DataTable dt = DBConnection.GetDataTable("GetPersonList", CommandType.StoredProcedure, paramenter ))
            {
                if (dt.Rows.Count>0)
                {
                    ListPerson = new List<PersonalInfo>();

                    foreach(DataRow row in dt.Rows)
                    {
                        PersonalInfo person = new PersonalInfo();
                        person.PersonID = Convert.ToInt32(row["PersonID"]);
                        person.LastName = row["LastName"].ToString();
                        person.FirstName = row["FirstName"].ToString();
                        person.Gender = row["Gender"].ToString();
                        DateTime testDT = DateTime.Parse(DateTime.Parse(row["Birthday"].ToString()).ToShortDateString());
                        person.Birthday = DateTime.Parse(DateTime.Parse(row["Birthday"].ToString()).ToShortDateString());
                        person.Address1 = row["Address1"].ToString();
                        person.Address2 = row["Address2"].ToString();
                        person.City = row["City"].ToString();
                        person.Country = row["Country"].ToString();

                        person.PhoneNumber = row["PhoneNumber"].ToString();
                        person.Email = row["Email"].ToString();

                        person.HighSchool = row["HighSchool"].ToString();
                        person.College = row["College"].ToString();
                        person.GraduatedSchool = row["GraduatedSchool"].ToString();
                        person.Major = row["Major"].ToString();
                        person.StartDate = DateTime.Parse(DateTime.Parse(row["StartDate"].ToString()).ToShortDateString());
                        person.EndDate = DateTime.Parse(DateTime.Parse(row["EndDate"].ToString()).ToShortDateString()); ;

                        person.Role = row["Role"].ToString();
                        person.Industry = row["Industry"].ToString();
                        person.Company = row["Company"].ToString();
                        person.ContractType = row["ContractType"].ToString();
                        person.FromDate = DateTime.Parse(DateTime.Parse(row["FromDate"].ToString()).ToShortDateString());
                        person.ToDate = DateTime.Parse(DateTime.Parse(row["ToDate"].ToString()).ToShortDateString());
                            
                        ListPerson.Add(person);
                    }
                }
            }
            return ListPerson;
        }

        public PersonalInfo GetPerosnDetail(int PersonID)
        {
            PersonalInfo person = null;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PersonID",PersonID)
            };
            using (DataTable dt = DBConnection.GetDataTable("GetPersonDetails", CommandType.StoredProcedure, parameters))
            {
                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];
                    person = new PersonalInfo();

                    person.PersonID = Convert.ToInt32(row["PersonID"]);
                    person.FirstName = row["FirstName"].ToString();
                    person.LastName = row["LastName"].ToString();
                    person.Gender = row["Gender"].ToString();
                    person.Birthday = DateTime.Parse(row["Birthday"].ToString());
                    person.Address1 = row["Address1"].ToString();
                    person.Address2 = row["Address2"].ToString();
                    person.City = row["City"].ToString();
                    person.Country = row["Country"].ToString();
                    person.PhoneNumber = row["PhoneNumber"].ToString();
                    person.Email = row["Email"].ToString();
                    person.HighSchool = row["HighSchool"].ToString();
                    person.College = row["College"].ToString();
                    person.GraduatedSchool = row["GraduatedSchool"].ToString();
                    person.Major = row["Major"].ToString();
                    person.StartDate = DateTime.Parse(row["StartDate"].ToString());
                    person.EndDate = DateTime.Parse(row["EndDate"].ToString());
                    person.Role = row["Role"].ToString();
                    person.Industry = row["Industry"].ToString();
                    person.Company = row["Company"].ToString();
                    person.ContractType = row["ContractType"].ToString();
                    person.FromDate = DateTime.Parse(row["FromDate"].ToString());
                    person.ToDate = DateTime.Parse(row["ToDate"].ToString());
                }
            }
            return person;
        }
    }
}
