using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssistanceSystem.Common.Dtos.Userposition
{
    public class UserPosition
    {
        public int userPosition { get; set; }
        public int userID { get; set; }
        public int roleID  { get; set; }
        public string created { get; set; }
        public string changed { get; set; }
    }
}
