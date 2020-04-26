using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolioClasses.UserManagement;
using System.Collections.Generic;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserAdd
    {
        [TestMethod]
        public void AddMethodOk()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            List<clsCustomerUser> testList = new List<clsCustomerUser>();

            Int32 primaryKey = 0;

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

            primaryKey = allCustomers.Add();
            testItem.UserId = primaryKey;

            allCustomers.thisCustomerUser.Find(primaryKey);
            Assert.AreEqual(allCustomers.thisCustomerUser, testItem);
        }
    }
}
