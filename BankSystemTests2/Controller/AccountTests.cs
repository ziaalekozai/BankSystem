using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankSystem.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Model;

namespace BankSystem.Controller.Tests
    {
    [TestClass()]
    public class AccountTests
        {
     
        public User UserList()
            {
            var userBank = new User
                {
                UserName = "zia1",
                Password = "zia123",
                Balance = 10000,
                Salary = 40000,
                Role = "backende",
                AccountNumber = 12122
                };
            return userBank;
            }
        [TestMethod()] // createAccountTest
        public void IfUserNameHasLetterAndDigit()
            {
            var user = new User();
            var actual = user.UserName = "zia16";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsTrue(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfUserNameDoesNotHaveDigit()
            {
            var user = new User();
            var actual = user.UserName = "zia";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfUserNameDoesNotHaveLetter()
            {
            var user = new User();
            var actual = user.UserName = "222";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfUserNameDoesIsEmpty()
            {
            var user = new User();
            var actual = user.UserName = "   ";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfUserNamedHasSymbol()
            {
            var list = new[] { "~","`","!","@","#","$","%","^","&","*","(",")","+","=" };
            var user = new User();
            var actual = user.UserName = "mathilda@123";
            var expected = !list.Any(user.UserName.Contains);
            Assert.IsFalse(expected,actual);
            }
        public void IfPasswordHasLetterAndDigit()
            {
            var user = new User();
            var actual = user.Password = "zia16";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsTrue(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfPasswordDoesNotHaveDigit()
            {
            var user = new User();
            var actual = user.Password = "zia";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfPasswordDoesNotHaveLetter()
            {
            var user = new User();
            var actual = user.Password = "222";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfPasswordDoesIsEmpty()
            {
            var user = new User();
            var actual = user.Password = "   ";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected,actual);
            }
        [TestMethod()] // createAccountTest
        public void IfPasswordHasSymbol()
            {
            var list = new[] { "~","`","!","@","#","$","%","^","&","*","(",")","+","=" };
            var user = new User();
            var actual = user.Password = "mathilda@123";
            var expected = !list.Any(user.Password.Contains);
            Assert.IsFalse(expected,actual);
            }

        
        [TestMethod()]
        public void IfDepositIsMoreThenSalary()
            {
            var deposit = UserList();
            var actual = deposit.Salary = 45000;
            var expected = deposit.Salary;
            Assert.AreEqual(expected,actual);
            }
        }
    }