using System;
using FolioClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting
{
    [TestClass]
    public class TstUserManagement
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsUser AUser = new ClsUser();
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            ClsUser aUser = new ClsUser();
            Boolean found = false;
            Int32 userID = 1;
            found = aUser.Find(userID);
            Assert.IsTrue(found);
        }
    }
}
