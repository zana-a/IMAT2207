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
        [TestMethod]
        public void FindMethodOK()
        {
            clsAuthor AnAuthor = new clsAuthor();
            Boolean Found = false;
            Int32 AuthorNo = 1;
            Found = AnAuthor.Find(AnAuthor);
            Asser.IsTrue(Found);
        }
    }
}
