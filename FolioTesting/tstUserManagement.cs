using System;
using FolioClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting
{
    [TestClass]
    public class tstUserManagement
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsUser AUser = new clsUser();
            Assert.IsNotNull(AUser);
        }
    }
}
