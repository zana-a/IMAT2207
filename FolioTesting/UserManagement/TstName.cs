using System;
using FolioClasses.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class TstName
    {       
        [TestMethod]
        public void InstanceOk()
        {
            Name aName = new Name("Barry Bones");

            Assert.IsNotNull(aName);
        }
    }
}
