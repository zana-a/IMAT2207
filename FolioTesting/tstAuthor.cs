using System;
using FolioClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting
{
    [TestClass]
    public class tstAuthor
    {
        [TestMethod]
        public void InstanceOf()
        {
            clsAuthor AnAuthor = new clsAuthor();
            Assert.IsNotNull(AnAuthor);
        }
    }
}
