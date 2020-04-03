using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Tests.Exceptions
{ 
  public  class UserNotFoundException :Exception
    {
        public string message = "User is Not Found Please SignUp";

        public UserNotFoundException()
        {

        }
        public UserNotFoundException(string messages)
        {
            message = messages;
        }
    }
}
