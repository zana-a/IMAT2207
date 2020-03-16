using System;
using FolioClasses.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class TstCustomerUser
    {
        // Good Test Data
        // Some test data to pass to the valid method
        string fullname = "Barry Bones";
        string password = "pass123";
        string dob = Convert.ToDateTime("08/04/1999").ToString();
        string email = "someone@email.com";
        string telephone = "+447900000000";
        string numOfBooksBought = "123";

        [TestMethod]
        public void InstanceOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            Assert.IsNotNull(aCustomerUser);
        }

        [TestMethod]
        public void UserIdOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            Int32 testData = 1;
            aCustomerUser.UserId = testData;
            Assert.AreEqual(aCustomerUser.UserId, testData);
        }

        [TestMethod]
        public void NameOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            String testData = "Barry Bones";
            aCustomerUser.Fullname = testData;
            Assert.AreEqual(aCustomerUser.Fullname, testData);
        }

        [TestMethod]
        public void PasswordOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            String testData = "pass123";
            aCustomerUser.Password = testData;
            Assert.AreEqual(aCustomerUser.Password, testData);
        }

        [TestMethod]
        public void DobOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            DateTime testData = Convert.ToDateTime("08/04/1999");
            aCustomerUser.Dob = testData;
            Assert.AreEqual(aCustomerUser.Dob, testData);
        }

        [TestMethod]
        public void EmailOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            String testData = "someone@email.com";
            aCustomerUser.Email = testData;
            Assert.AreEqual(aCustomerUser.Email, testData);
        }

        [TestMethod]
        public void TelephoneOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            String testData = "+447900000000";
            aCustomerUser.Telephone = testData;
            Assert.AreEqual(aCustomerUser.Telephone, testData);
        }

        [TestMethod]
        public void NumOfBooksBoughtOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            Int32 testData = 123;
            aCustomerUser.NumOfBooksBought = testData;
            Assert.AreEqual(aCustomerUser.NumOfBooksBought, testData);
        }

        [TestMethod]
        public void IsEmailVerifiedOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            String testData = "someone@email.com";
            aCustomerUser.Email = testData;
            Assert.AreEqual(aCustomerUser.Email, testData);
        }

        [TestMethod]
        public void FindUserIdOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
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
            CustomerUser aCustomerUser = new CustomerUser();
            Boolean found = false;
            Int32 userId = 5;
            found = aCustomerUser.Find(userId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            CustomerUser aCustomerUser = new CustomerUser();
            String error = "";
            error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            Assert.AreEqual(error, "");
        }
    }
}