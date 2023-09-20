using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssistanceSystem.Common.Dtos
{
    public class UserDto
    {
        public int userID { get; set; }
        public string  userName { get; set; }
        public string password { get; set; }
        public int personID { get; set; }
        public int isDeleted { get; set; }
        public string commencementDate { get; set; }
        public string  created { get; set; }
        public string changed { get; set; }
    }
}
