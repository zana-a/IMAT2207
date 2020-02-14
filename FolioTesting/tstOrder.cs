using System;
using FolioClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder);
        }
    }
}
