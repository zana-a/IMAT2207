using System;
using FolioClasses.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserFind
    {
        [TestMethod]
        public void FindUserIdOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.UserId != userId)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindFullnameOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String fullname = "Barry Bones";
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.Fullname != fullname)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindPasswordOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String password = "pass123";
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.Password != password)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindDobOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            DateTime dob = Convert.ToDateTime("08/04/1999");
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.Dob != dob)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindEmailOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String email = "someone@email.com";
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.Email != email)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindTelephoneOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String telephone = "+447900000000";
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.Telephone != telephone)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindNumOfBooksBoughtOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            Int32 numOfBooksBought = 123;
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.NumOfBooksBought != numOfBooksBought)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindIsEmailVerifiedOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            Boolean isVerified = true;
            found = aCustomerUser.Find(userId);

            if (aCustomerUser.IsEmailVerified != isVerified)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Int32 userId = 5;
            found = aCustomerUser.Find(userId);
            Assert.IsTrue(found);
        }
    }
}