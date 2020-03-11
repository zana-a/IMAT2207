using System;
using FolioClasses.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class TstCostumerUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Assert.IsNotNull(aCostumerUser);
        }

        [TestMethod]
        public void UserIdOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Int32 testData = 1;
            aCostumerUser.UserId = testData;
            Assert.AreEqual(aCostumerUser.UserId, testData);
        }

        [TestMethod]
        public void NameOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            String testData = "Barry Bones";
            aCostumerUser.Fullname = testData;
            Assert.AreEqual(aCostumerUser.Fullname, testData);
        }

        [TestMethod]
        public void PasswordOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            String testData = "pass123";
            aCostumerUser.Password = testData;
            Assert.AreEqual(aCostumerUser.Password, testData);
        }

        [TestMethod]
        public void DobOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            DateTime testData = Convert.ToDateTime("08/04/1999");
            aCostumerUser.Dob = testData;
            Assert.AreEqual(aCostumerUser.Dob, testData);
        }

        [TestMethod]
        public void EmailOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            String testData = "someone@email.com";
            aCostumerUser.Email = testData;
            Assert.AreEqual(aCostumerUser.Email, testData);
        }

        [TestMethod]
        public void TelephoneOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            String testData = "+447900000000";
            aCostumerUser.Telephone = testData;
            Assert.AreEqual(aCostumerUser.Telephone, testData);
        }

        [TestMethod]
        public void NumOfBooksBoughtOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Int32 testData = 123;
            aCostumerUser.NumOfBooksBought = testData;
            Assert.AreEqual(aCostumerUser.NumOfBooksBought, testData);
        }

        [TestMethod]
        public void IsEmailVerifiedOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            String testData = "someone@email.com";
            aCostumerUser.Email = testData;
            Assert.AreEqual(aCostumerUser.Email, testData);
        }

        [TestMethod]
        public void FindUserIdOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.UserId != userId)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindFullnameOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            String fullname = "Barry Bones";
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.Email != fullname)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindPasswordOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            String password = "pass123";
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.Password != password)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindDobOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            DateTime dob = Convert.ToDateTime("08/04/1999");
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.Dob != dob)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindEmailOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            String email = "someone@email.com";
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.Email != email)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindTelephoneOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            String telephone = "+447900000000";
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.Telephone != telephone)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindNumOfBooksBoughtOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            Int32 numOfBooksBought = 123;
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.NumOfBooksBought != numOfBooksBought)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindIsEmailVerifiedOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Boolean ok = true;
            Int32 userId = 1;
            Boolean isVerified = true;
            found = aCostumerUser.Find(userId);

            if (aCostumerUser.IsEmailVerified != isVerified)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            CostumerUser aCostumerUser = new CostumerUser();
            Boolean found = false;
            Int32 userId = 1;
            found = aCostumerUser.Find(userId);
            Assert.IsTrue(found);
        }
    }
}
