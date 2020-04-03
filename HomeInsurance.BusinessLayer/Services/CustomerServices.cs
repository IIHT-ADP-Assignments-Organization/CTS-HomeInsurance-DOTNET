using HomeInsurance.BusinessLayer.Interfaces;
using HomeInsurance.DataLayer.NHibernate;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.BusinessLayer.Services
{
    public class CustomerServices : ICustomerServices
    {
       
       private readonly IMapperSession _session;

       public CustomerServices(IMapperSession session)
        {
         _session = session;
        }

        public Qoute ApplyQoute(Residance residance, Property property)
        {
            throw new NotImplementedException();
        }

        public Policy BuyPolicy(Qoute qoute)
        {
            throw new NotImplementedException();
        }

        public Residance RetrieveQuote(long userid)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool SignOut()
        {
            throw new NotImplementedException();
        }

        public bool SignUp(User user)
        {
            throw new NotImplementedException();
        }

        public Policy ViewPolicy(string policyKey)
        {
            throw new NotImplementedException();
        }
    }
}
