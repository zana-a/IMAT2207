using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolioClasses.UserManagement;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserInstance
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Assert.IsNotNull(aCustomerUser);
        }

        [TestMethod]
        public void UserIdOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Int32 testData = 1;
            aCustomerUser.UserId = testData;
            Assert.AreEqual(aCustomerUser.UserId, testData);
        }

        [TestMethod]
        public void NameOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            String testData = "Barry Bones";
            aCustomerUser.Fullname = testData;
            Assert.AreEqual(aCustomerUser.Fullname, testData);
        }

        [TestMethod]
        public void PasswordOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            String testData = "pass123";
            aCustomerUser.Password = testData;
            Assert.AreEqual(aCustomerUser.Password, testData);
        }

        [TestMethod]
        public void DobOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            DateTime testData = Convert.ToDateTime("08/04/1999");
            aCustomerUser.Dob = testData;
            Assert.AreEqual(aCustomerUser.Dob, testData);
        }

        [TestMethod]
        public void EmailOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            String testData = "someone@email.com";
            aCustomerUser.Email = testData;
            Assert.AreEqual(aCustomerUser.Email, testData);
        }

        [TestMethod]
        public void TelephoneOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            String testData = "+447900000000";
            aCustomerUser.Telephone = testData;
            Assert.AreEqual(aCustomerUser.Telephone, testData);
        }

        [TestMethod]
        public void NumOfBooksBoughtOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Int32 testData = 123;
            aCustomerUser.NumOfBooksBought = testData;
            Assert.AreEqual(aCustomerUser.NumOfBooksBought, testData);
        }

        [TestMethod]
        public void IsEmailVerifiedOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            String testData = "someone@email.com";
            aCustomerUser.Email = testData;
            Assert.AreEqual(aCustomerUser.Email, testData);
        }

    }
}
