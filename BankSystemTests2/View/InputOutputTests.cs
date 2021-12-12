using BankSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankSystem.View.Tests
    {
    [TestClass()]
    public class InputOutputTests
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

        public Admin AdminList()
            {
            var adminBank =
            new Admin
                {
                UserName = "admin1",
                Password = "admin1234",
                AccountNumber = "123-123",
                Balance = 0,
                Salary = 50000,
                Role = "admin"
                };
            return adminBank;
            }

        //Test for userlist och user log in.
        [TestMethod()]
        public void If_UserName_correct()
            {
            var userBank = UserList();
            var actual = userBank.UserName = "zia1";
            var expected = UserList();
            Assert.AreEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void If_UserName_Is_Empty()
            {
            var userBank = UserList();
            var actual = userBank.UserName = " ";
            var expected = UserList();
            Assert.AreNotEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void If_User_Not_Correct()
            {
            var userBank = UserList();
            var actual = userBank.Password = "matild";
            var expected = UserList();
            Assert.AreNotEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void If_Password_Not_Correct()
            {
            var userBank = UserList();
            var actual = userBank.Password = "zia12";
            var expected = UserList();
            Assert.AreNotEqual(expected.Password,actual);
            }

        [TestMethod()]
        public void If_Password_Correct()
            {
            var userBank = UserList();
            var actual = userBank.Password = "zia123";
            var expected = UserList();
            Assert.AreEqual(expected.Password,actual);
            }

        [TestMethod()]
        public void If_UserRole_Empty()
            {
            var userBank = UserList();
            var actual = userBank.Role = "";
            var expected = UserList();
            Assert.AreNotEqual(expected.Role,actual);
            }

        [TestMethod()]
        public void If_UserRole_Correct()
            {
            var userBank = UserList();
            var actual = userBank.Role = "backende";
            var expected = UserList();
            Assert.AreEqual(expected.Role,actual.ToLower());
            }

        [TestMethod()]
        public void If_UserRole_Capital_Letter()
            {
            var userBank = UserList();
            var actual = userBank.Role = "BACKENDE";
            var expected = UserList();
            Assert.AreEqual(expected.Role,actual.ToLower());
            }

        [TestMethod()]
        public void If_UserRole_Not_Correct()
            {
            var userBank = UserList();
            var actual = userBank.Role = "IT";
            var expected = UserList();
            Assert.AreNotEqual(expected.Role,actual.ToLower());
            }

        [TestMethod()]
        public void IfUserNotExcist()
            {
            var userBank = UserList();
            var actual = userBank.Password = "alex";
            var expected = UserList();
            Assert.AreNotEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void IfPasswordIsSame()
            {
            var userBank = UserList();
            var actual = userBank.Password = "zia123";
            var expected = UserList();
            Assert.AreEqual(expected.Password,actual);
            }

        //Test for adminlist och admin log in.
        [TestMethod()]
        public void if_AdminName_Same()
            {
            var admin = AdminList();
            var actual = admin.UserName = "admin1";
            var expected = AdminList();
            Assert.AreEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void If_AdminName_Not_Same()
            {
            var admin = AdminList();
            var actual = admin.UserName = "adminnnn111";
            var expected = AdminList();
            Assert.AreNotEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void If_AdminName_Empty()
            {
            var admin = AdminList();
            var actual = admin.UserName = "";
            var expected = AdminList();
            Assert.AreNotEqual(expected.UserName,actual);
            }

        [TestMethod()]
        public void If_AdminName_capital_letter()
            {
            var admin = AdminList();
            var actual = admin.UserName = "ADMIN1";
            var expected = AdminList();
            Assert.AreEqual(expected.UserName,actual.ToLower());
            }

        [TestMethod()]
        public void If_AdminPassword_capital_letter()
            {
            var admin = AdminList();
            var actual = admin.Password = "ADMIN1234";
            var expected = AdminList();
            Assert.AreEqual(expected.Password,actual.ToLower());
            }

        [TestMethod()]
        public void If_AdminPassword_Not_correct()
            {
            var admin = AdminList();
            var actual = admin.Password = "adminn11";
            var expected = AdminList();
            Assert.AreNotEqual(expected.Password,actual.ToLower());
            }

        [TestMethod()]
        public void If_AdminPassword_correct()
            {
            var admin = AdminList();
            var actual = admin.Password = "admin1234";
            var expected = AdminList();
            Assert.AreEqual(expected.Password,actual.ToLower());
            }

        [TestMethod()]
        public void If_AdminPassword_Empty()
            {
            var admin = AdminList();
            var actual = admin.Password = "";
            var expected = AdminList();
            Assert.AreNotEqual(expected.Password,actual.ToLower());
            }

        [TestMethod()]
        public void If_AdminRole_Empty()
            {
            var admin = AdminList();
            var actual = admin.Role = "";
            var expected = AdminList();
            Assert.AreNotEqual(expected.Role,actual);
            }

        [TestMethod()]
        public void If_AdminRole_Correct()
            {
            var admin = AdminList();
            var actual = admin.Role = "admin";
            var expected = AdminList();
            Assert.AreEqual(expected.Role,actual);
            }

        [TestMethod()]
        public void If_AdminRole_Capital_Letter()
            {
            var admin = AdminList();
            var actual = admin.Role = "ADMIN";
            var expected = AdminList();
            Assert.AreEqual(expected.Role,actual.ToLower());
            }

        [TestMethod()]
        public void If_AdminRole_Not_Correct()
            {
            var admin = AdminList();
            var actual = admin.Role = "User";
            var expected = AdminList();
            Assert.AreNotEqual(expected.Role,actual.ToLower());
            }

        [TestMethod()]
        public void Change_User_Role()
            {
            var role = UserList();
            var actual = role.Role = "backende";
            actual.Remove(1);
            var expected = role.Role = "CO";
            Assert.AreNotEqual(expected,actual);
            }
        }
    }