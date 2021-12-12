using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.

namespace BankSystemTest.Controller
    {
    class AccountTests
        {

        [TestClass()]
        public class AccountTests
            {
            [TestMethod()]
            public void IsUserNameString()
                {
                var userList = new User();
                var actual = userList.UserName = "";

                Assert.IsTrue(true,actual);
                }
            //public void IsUserNameNotString()
            //    {
            //    var userList = new User();
            //    var actual = userList.UserName = "2,2";

            //    Assert.IsTrue(true,actual);
            //    }
            [TestMethod()]
            public void IsPasswordString()
                {
                var userList = new User();
                var actual = userList.Password = "";

                Assert.IsTrue(true,actual);
                }

            //[TestMethod()]
            //public void IsSalareDouble()
            //    {
            //    var userList = new User();
            //     double actual = userList.Salary = 10.10;
            //    double expected = double;
            //    Assert.AreEqual(expected, actual);
            //    }

            [TestMethod()]
            public void IsRoleString()
                {
                var userList = new User();
                var actual = userList.Role = "";

                Assert.IsTrue(true,actual);
                }
            }
        }
    }
