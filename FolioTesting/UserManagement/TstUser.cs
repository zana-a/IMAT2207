using System;
using FolioClasses.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class TstUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            int id = 1;
            Name name = new Name("Steve Jobs");
            string password = "iamgenius123";
            string dob = "08/04/1999";
            string email = "steve@apple.com";
            string telephone = "007914724741";
            int numOfBooksBought = 1;

            User aUser = new User(id, name, password, dob, email, telephone, numOfBooksBought);

            Assert.IsNotNull(aUser);
        }

        [TestMethod]
        public void TestUserIdPropertyOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserNamePropertyOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserPasswordPropertyOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserDobPropertyOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserEmailPropertyOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserTelPropertyOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserNumOfBooksBoughtPropertyOk()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TestUserSetNameOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserSetPasswordOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserSetDobOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserSetEmailOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserSetTelOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserGetId()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserGetNameOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserGetPasswordOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserGetDobOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserGetEmailOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserGetTelOk()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserNameFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserPasswordFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserDobFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserEmailFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserTelFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestUserNumOfBooksBoughtFound()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void FindMethodOk()
        {
            throw new NotImplementedException();
        }
    }
}
