using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusicLogicLayer
{
    public class PersonalInfoHandler
    {
        PersonalInfoDBAccess personDB = null;

        public PersonalInfoHandler()
        {
            personDB = new PersonalInfoDBAccess();
        }

        public bool AddNewPersonalInfo(PersonalInfo personInfo)
        {
            return personDB.AddNewPersonalInfo(personInfo);
        }

        public List<PersonalInfo> GetPersonList()
        {
            return personDB.GetPersonList();
        }

        public PersonalInfo GetPersonDetails(int PersonID)
        {
            return personDB.GetPerosnDetail(PersonID);
        }

        public bool UpdatePersonInfo(PersonalInfo person)
        {
            return personDB.UpdatePersonInfo(person);
        }

        public bool DeletePerson(int PersonID)
        {
            return personDB.DeletePeronInfo(PersonID);
        }
    }
}
