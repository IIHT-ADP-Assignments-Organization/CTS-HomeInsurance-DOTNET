using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Entities
{
   public class User
    {
       public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public long Mobile { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public bool IsRetired { get; set; }
        public bool IsValid { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string UserType { get; set; }
    }
}
