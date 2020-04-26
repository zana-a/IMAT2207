using System;
using System.Collections.Generic;
using FolioClasses.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserUpdate
    {
        [TestMethod]
        public void UpdateMethodOk()
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

            testItem.UserId = 23;
            testItem.Fullname = "Dingle May";
            testItem.Password = "dd123";
            testItem.Dob = Convert.ToDateTime("02/05/1997");
            testItem.Email = "dingle@may.com";
            testItem.Telephone = "+447227230004";
            testItem.NumOfBooksBought = 33;
            testItem.IsEmailVerified = true;

            allCustomers.thisCustomerUser = testItem;
            allCustomers.Update();

            allCustomers.thisCustomerUser.Find(primaryKey);

            Assert.AreEqual(allCustomers.thisCustomerUser, testItem);
        }
    }
}
