using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolioClasses.UserManagement;
using System.Collections.Generic;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            Assert.IsNotNull(allCustomers);
        }

        [TestMethod]
        public void CustomerUserListOk()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            List<clsCustomerUser> testList = new List<clsCustomerUser>();

            clsCustomerUser testItem = new clsCustomerUser();
            testItem.UserId = 1;
            testItem.Fullname = "James May";
            testItem.Password = "james123";
            testItem.Dob = Convert.ToDateTime("02/03/1977");
            testItem.Email = "james@may.com";
            testItem.Telephone = "+447887234554";
            testItem.NumOfBooksBought = 0;
            testItem.IsEmailVerified = false;

            testList.Add(testItem);

            allCustomers.CustomerUserList = testList;
            Assert.AreEqual(allCustomers.CustomerUserList, testList);
        }

        [TestMethod]
        public void ThisCustomerUserPropertyOk()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            clsCustomerUser testItem = new clsCustomerUser();

            testItem.UserId = 1;
            testItem.Fullname = "James May";
            testItem.Password = "james123";
            testItem.Dob = Convert.ToDateTime("02/03/1977");
            testItem.Email = "james@may.com";
            testItem.Telephone = "+447887234554";
            testItem.NumOfBooksBought = 0;
            testItem.IsEmailVerified = false;
            allCustomers.thisCustomerUser = testItem;
            Assert.AreEqual(allCustomers.thisCustomerUser, testItem);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            clsCustomerUser testItem = new clsCustomerUser();

            List<clsCustomerUser> testList = new List<clsCustomerUser>();

            testItem.UserId = 1;
            testItem.Fullname = "James May";
            testItem.Password = "james123";
            testItem.Dob = Convert.ToDateTime("02/03/1977");
            testItem.Email = "james@may.com";
            testItem.Telephone = "+447887234554";
            testItem.NumOfBooksBought = 0;
            testItem.IsEmailVerified = false;

            testList.Add(testItem);
            allCustomers.CustomerUserList = testList;
            Assert.AreEqual(testList.Count, allCustomers.Count);
        }
    }
}
