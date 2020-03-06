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
            User aUser = new User();
            Assert.IsNotNull(aUser);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            User aUser = new User();
            Boolean found = false;
            Int32 id = 1;
            found = aUser.Find(id);
            Assert.IsTrue(found);
        }
         
        [TestMethod]
        public void TestUserFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.UserId != 1)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestUserNameFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.Name != "Barry Bones")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestUserPasswordFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.Password != "pass123")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestUserDobFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.Dob != Convert.ToDateTime("08/04/1999"))
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestUserEmailFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.Email != "someone@email.com")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestUserTelephoneFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.Telephone != "+442427184745")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestUserNumOfBookBoughtFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.NumOfBooksBought != 123)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestIsUserVerifiedFound()
        {
            User aUser = new User();

            Boolean found = false;
            Int32 id = 1;
            Boolean ok = true;

            found = aUser.Find(id);

            if (aUser.IsEmailVerified != true)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }
    }
}
