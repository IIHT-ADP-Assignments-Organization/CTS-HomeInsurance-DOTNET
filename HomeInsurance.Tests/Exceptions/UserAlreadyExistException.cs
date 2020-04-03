using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.Tests.Exceptions
{ 
  public  class UserAlreadyExistException :Exception
    {
        public string message = "Already have an Account please login";

        public UserAlreadyExistException()
        {

        }
        public UserAlreadyExistException(string messages)
        {
            message = messages;
        }
    }
}
