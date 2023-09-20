using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssistanceSystem.Common.Dtos.Person
{
    public class Person
    {
        public int personID { get; set; }
        public int titleID { get; set; }
        public string genderID { get; set; }
        public string FirstName { get; set; }
        public string  Surname { get; set; }
        public string idNumber { get; set; }
        public string  EmailAdress { get; set; }
        public string  HomeAdress { get; set; }
        public string streetAdreess { get; set; }
    }
}
