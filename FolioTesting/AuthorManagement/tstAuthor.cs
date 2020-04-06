using System;
using FolioClasses.AuthorManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.AuthorManagement
{
    [TestClass]
    public class tstAuthor
    {        
        [TestMethod]
        public void Instanceok()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Assert.IsNotNull(AnAuthor);
        }
        [TestMethod]
        public void AuthorIdok()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Int32 TestData = 1;
            AnAuthor.AuthorId = TestData;
            Assert.AreEqual(AnAuthor.AuthorId, TestData);
        }
        [TestMethod]
        public void AuthorNameok()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String TestData = "";
            AnAuthor.Name = TestData;
            Assert.AreEqual(AnAuthor.Name, TestData);
        }
        [TestMethod]
        public void AuthorDobOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            DateTime TestData = DateTime.Now.Date;
            AnAuthor.DOB = TestData;
            Assert.AreEqual(AnAuthor.DOB, TestData);
        }
        [TestMethod]
        public void AuthorIsAliveOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean TestData = true;
            AnAuthor.IsAlive = TestData;
            Assert.AreEqual(AnAuthor.IsAlive, TestData);
        }
        [TestMethod]
        public void FindAuthorIdOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean found = false;
            Boolean ok = true;
            Int32 AuthorID = 7;
            found = AnAuthor.Find(AuthorID);
            if(AnAuthor.AuthorId != AuthorID)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void FindAuthorNameOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean found = false;
            Boolean ok = true;
            Int32 AuthorID = 9;
            String fullname = "J.R.R.Tolkien";
            found = AnAuthor.Find(AuthorID);
            if(AnAuthor.Name != fullname)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void FindAuthorDobOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean found = false;
            Boolean ok = true;
            Int32 AuthorID = 9;
            found = AnAuthor.Find(AuthorID);
            if(AnAuthor.DOB != Convert.ToDateTime("03/01/1892")){
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void FindAuthorIsAliveOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean found = false;
            Boolean ok = true;
            Int32 AuthorID = 9;
            found = AnAuthor.Find(AuthorID);
            if(AnAuthor.IsAlive != false)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean found = false;
            Int32 AuthorID = 9;
            found = AnAuthor.Find(AuthorID);
            Assert.IsTrue(found);
        }
    }
}
