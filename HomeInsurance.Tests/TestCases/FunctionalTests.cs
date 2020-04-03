using HomeInsurance.BusinessLayer.Interfaces;
using HomeInsurance.BusinessLayer.Services;
using HomeInsurance.DataLayer.NHibernate;
using HomeInsurance.Entities;
using NSubstitute;

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HomeInsurance.Tests.TestCases
{
  public  class FunctionalTests
    {
        private readonly ICustomerServices _service;
        private readonly IAdminServices _adminService;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTests()
        {
            _service = new CustomerServices(_session);
            _adminService = new AdminServices(_session);
        }

        [Fact]
        public void Test_For_Valid_CreateAccount()
        {
            //Arrange
            var user = new User()
            {
                UserId = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Mobile = 9908765433,
                Password = "12345678",
                Email = "abc@gmail.com",
                DOB = new DateTime(1985, 2, 3),
                IsRetired = true,
                IsValid = true,
                SocialSecurityNumber = 987654321,
                UserType = "Admin"
            };
            //Action
            var IsRegistered = _service.SignUp(user);
            //Assert
            Assert.True(IsRegistered);
        }

        [Fact]
        public void Test_For_Valid_Login()
        {
            //Arrange
            var user = new User()
            {
                UserId = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Mobile = 9908765433,
                Password = "12345678",
                Email = "abc@gmail.com",
                DOB = new DateTime(1985, 2, 3),
                IsRetired = true,
                IsValid = true,
                SocialSecurityNumber = 987654321,
                UserType = "Admin"
            };
            //Action
            var IsLogged = _service.SignIn(user.UserName, user.Password);
            //Assert
            Assert.True(IsLogged);
        }

        [Fact]
        public void Test_For_Valid_SignOut()
        {
            //Arrange
            //Action
            var IsSignedOut = _service.SignOut();
            //Assert
            Assert.True(IsSignedOut);
        }

        [Fact]
        public void Test_For_Valid_ViewPolicy()
        {
            //Arrange
            var policy = new Policy()
            {
                PolicyKey="p1",
                QuoteId="q1"
            };
            //Action
            var getPolicy = _service.ViewPolicy(policy.PolicyKey);
            //Assert
            Assert.NotNull(getPolicy);
        }

        [Fact]
        public void Test_For_Valid_BuyPolicy()
        {
            //Arrange
            var qoute = new Qoute()
            {
                QouteId="q1",
                UserId=12345
            };

            //Action
            var getPolicy = _service.BuyPolicy(qoute);
            var expectedPolicy = _service.ViewPolicy(getPolicy.PolicyKey);
            //Assert
            Assert.Equal(expectedPolicy, getPolicy);
        }

        [Fact]
        public void Test_For_Valid_ApplyQoute()
        {
            //Arrange Qoute ApplyQoute(Residance residance,Property property);
            var residance = new Residance()
            {
                QuoteId = "Q1",
                AddressLine1 = "Bangalore",
                City = "Bangalore",
                Zip = 675201
            };
            var property = new Property()
            {
                PropertyId=12345,
                QouteId="q1",
                UserId=1234
            };

            //Action
            var getQoute = _service.ApplyQoute(residance, property);
            //Assert
            Assert.NotNull(getQoute);
        }

        [Fact]
        public void Test_For_Valid_CloseAccount()
        {
            //Arrange
            var user = new User()
            {
                UserId = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Mobile = 9908765433,
                Password = "12345678",
                Email = "abc@gmail.com",
                DOB = new DateTime(1985, 2, 3),
                IsRetired = true,
                IsValid = true,
                SocialSecurityNumber = 987654321,
                UserType = "Admin"
            };

            //Action
            var getQoute = _service.RetrieveQuote(user.UserId);
            //Assert
            Assert.NotNull(getQoute);
        }

       

        [Fact]
        public void Test_For_Valid_SearchUser()
        {
            //Arrange
            var user = new User()
            {
                UserId = 1234,
                FirstName = "Rose",
                LastName = "N",
                UserName = "Rose",
                Mobile = 9908765433,
                Password = "12345678",
                Email = "abc@gmail.com",
                DOB = new DateTime(1985, 2, 3),
                IsRetired = true,
                IsValid = true,
                SocialSecurityNumber = 987654321,
                UserType = "Admin"
            };

            //Action
            var getUser = _adminService.SearchUser(user.UserName);
            //Assert
            Assert.NotNull(getUser);
        }
       
        [Fact]
        public void Test_For_Valid_ViewPoicy()
        {
            //Arrange
            var policy = new Policy()
            {
                PolicyKey = "p1"

            };

            //Action
            var viewPolicy = _adminService.ViewPolicy(policy.PolicyKey);
            //Assert
            Assert.NotNull(viewPolicy);
        }

        [Fact]
        public void Test_For_Valid_RenewPolicy()
        {
            //Arrange
            var policy = new Policy()
            {
                PolicyKey = "p1"
            };

            //Action
            var renewedPolicy = _adminService.RenewPolicy(policy.PolicyKey);
            var viewPolicy = _adminService.ViewPolicy(policy.PolicyKey);
            //Assert
            Assert.Equal(viewPolicy, renewedPolicy);
        }

        [Fact]
        public void Test_For_Valid_CancelPolicy()
        {
            //Arrange
            var policy = new Policy()
            {
                PolicyKey="p1"
            };

            //Action
            var viewPolicy= _adminService.ViewPolicy(policy.PolicyKey);
            var CancelledPolicy = _adminService.CancellPolicy(policy.PolicyKey);
            //Assert
            Assert.Equal(viewPolicy,CancelledPolicy);
        }


        [Fact]
        public void Test_For_Valid_RetrieveQuote()
        {
            //Arrange
            var user = new User()
            {
                UserId=1234,
                UserName="Rose",
                Mobile = 9908765433,
                Password = "12345678",
                Email = "abc@gmail.com"
            };

            //Action
            var getResindancy = _adminService.RetrieveQuote(user.UserId);
            //Assert
            Assert.NotNull(getResindancy);
        }

    }
}
