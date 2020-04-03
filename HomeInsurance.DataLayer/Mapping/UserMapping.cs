using FluentNHibernate.Mapping;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.DataLayer.Mapping
{
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Id(x => x.UserId);

            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.Email);
            Map(x => x.DOB);
            Map(x => x.IsRetired);
            Map(x => x.IsValid);
            Map(x => x.Mobile);
            Map(x => x.SocialSecurityNumber);
            Map(x => x.UserType);
            
            Table("User");
        }
    }
}
    
