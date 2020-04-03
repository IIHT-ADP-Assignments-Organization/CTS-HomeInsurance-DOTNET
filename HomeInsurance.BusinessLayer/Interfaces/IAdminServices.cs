using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.BusinessLayer.Interfaces
{
  public  interface IAdminServices
    {
        bool SignUp(User user);
        bool SigIn(string userName, string password);
        bool SignOut();
        User SearchUser(string userName);
        Policy ViewPolicy(string policyKey);
        Policy RenewPolicy(string policyKey);
        Policy CancellPolicy(string PolicyKey);
        Residance RetrieveQuote(long userid);
    }
}
