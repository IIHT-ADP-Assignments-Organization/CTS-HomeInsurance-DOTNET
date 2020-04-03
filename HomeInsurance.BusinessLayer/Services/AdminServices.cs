using HomeInsurance.BusinessLayer.Interfaces;
using HomeInsurance.DataLayer.NHibernate;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }

        public Policy CancellPolicy(string PolicyKey)
        {
            throw new NotImplementedException();
        }

        public Policy RenewPolicy(string policyKey)
        {
            throw new NotImplementedException();
        }

        public Residance RetrieveQuote(long userid)
        {
            throw new NotImplementedException();
        }

        public User SearchUser(string userName)
        {
            throw new NotImplementedException();
        }

        public bool SigIn(string userName, string password)
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
