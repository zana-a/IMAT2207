using System;
using FolioClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting
{
    [TestClass]
    public class tstBooks
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBook ABook = new clsBook();
            Assert.IsNotNull(ABook);
        }
    }
}
