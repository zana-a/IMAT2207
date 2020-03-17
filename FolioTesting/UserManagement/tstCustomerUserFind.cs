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
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.UserId != userId)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindFullnameOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String fullname = "Barry Bones";
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.Fullname != fullname)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindPasswordOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String password = "pass123";
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.Password != password)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindDobOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            DateTime dob = Convert.ToDateTime("08/04/1999");
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.Dob != dob)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindEmailOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String email = "someone@email.com";
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.Email != email)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindTelephoneOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            String telephone = "+447900000000";
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.Telephone != telephone)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindNumOfBooksBoughtOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            Int32 numOfBooksBought = 123;
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.NumOfBooksBought != numOfBooksBought)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindIsEmailVerifiedOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 5;
            Boolean isVerified = true;
            found = aclsCustomerUser.Find(userId);

            if (aclsCustomerUser.IsEmailVerified != isVerified)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            Boolean found = false;
            Int32 userId = 5;
            found = aclsCustomerUser.Find(userId);
            Assert.IsTrue(found);
        }
    }
}