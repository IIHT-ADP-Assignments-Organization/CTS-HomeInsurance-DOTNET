using HomeInsurance.BusinessLayer.Interfaces;
using HomeInsurance.BusinessLayer.Services;
using HomeInsurance.DataLayer.NHibernate;
using HomeInsurance.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace HomeInsurance.Tests.TestCases
{
    public class BounadryTests
    {
        private readonly ICustomerServices _service;
        private readonly IAdminServices _adminService;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public BounadryTests()
        {
            _service = new CustomerServices(_session);
            _adminService = new AdminServices(_session);
        }


        [Fact]
        public void Boundary_Testfor_ValidEmail()
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

            bool isEmail = Regex.IsMatch(user.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void Boundary_Testfor_ValidSSN()
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
            Assert.Equal(9,user.SocialSecurityNumber.ToString().Length);
        }

        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
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
            Assert.Equal(10, user.Mobile.ToString().Length);
        }

        [Fact]
        public void Boundary_Testfor_ValidZipNumber()
        {
            //Action
            //Action
            var residance = new Residance()
            {
                QuoteId="Q1",
                AddressLine1="Bangalore",
                City= "Bangalore",
                Zip= 675201
            };

        //Assert
        Assert.Equal(6, residance.Zip.ToString().Length);
        }

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
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

            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
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

            var MinLength = 2;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
      
}