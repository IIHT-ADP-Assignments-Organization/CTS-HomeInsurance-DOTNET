using HomeInsurance.BusinessLayer.Interfaces;
using HomeInsurance.BusinessLayer.Services;
using HomeInsurance.DataLayer.NHibernate;
using HomeInsurance.Entities;
using HomeInsurance.Tests.Exceptions;
using NSubstitute;

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HomeInsurance.Tests.TestCases
{
   public class ExceptionTests
    {
        private readonly ICustomerServices _service;
        private readonly IAdminServices _adminService;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTests()
        {
            _service = new CustomerServices(_session);
            _adminService= new AdminServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_CustomerNotFound()
        {
            
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _service.SignIn("ABC","123456"));
            Assert.Equal("User is Not Found Please SignUp", ex.message);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
           
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.SignIn("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.message);
        }
        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.SignIn("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.message);
        }

        [Fact]
        public void ExceptionTestFor_ValidRegistration()
        {
            //Action
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
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _service.SignUp(user));
            Assert.Equal("Already have an Account please login", ex.message);
        }

    }
}
