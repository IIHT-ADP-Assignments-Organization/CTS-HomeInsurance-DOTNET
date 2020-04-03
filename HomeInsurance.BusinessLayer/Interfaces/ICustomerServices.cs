using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.BusinessLayer.Interfaces
{
   public interface ICustomerServices
    {
        bool SignUp(User user);
        bool SignIn(string userName, string password);
        bool SignOut();
        Policy ViewPolicy(string policyKey);
        Policy BuyPolicy(Qoute qoute);
        Qoute ApplyQoute(Residance residance,Property property);
        Residance RetrieveQuote(long userid);
    }
}
