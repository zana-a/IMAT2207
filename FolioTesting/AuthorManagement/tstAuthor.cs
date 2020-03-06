using System;
using FolioClasses.AuthorManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.AuthorManagement
{
    [TestClass]
    public class tstAuthor
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Assert.IsNotNull(AnAuthor);
        }
        [TestMethod]
        public void AuthorIdOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Int32 TestData = 1;
            AnAuthor.Id = TestData;
            Assert.AreEqual(AnAuthor.Id, TestData);
        }
        [TestMethod]
        public void AuthorNameOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String TestData = "";
            AnAuthor.Name = TestData;
            Assert.AreEqual(AnAuthor.Name, TestData);
        }
        [TestMethod]
        public void AuthorDOBOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            DateTime TestData = DateTime.Now.Date;
            AnAuthor.DOB = TestData;
            Assert.AreEqual(AnAuthor.DOB, TestData);
        }
        [TestMethod]
        public void AuthorIsDeadOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean TestData = true;
            AnAuthor.IsDead = TestData;
            Assert.AreEqual(AnAuthor.IsDead, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean Found = false;
            Int32 AuthorNo = 1;
            Found = AnAuthor.Find(AuthorNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindAuthorIDOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AuthorNo = 1;
            Found = AnAuthor.Find(AuthorNo);

            if(AnAuthor.Id != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindAuthorNameOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AuthorNo = 1;
            Found = AnAuthor.Find(AuthorNo);
            if(AnAuthor.Name != "Philip K. Dick")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindAuthorDOBOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AuthorNo = 1;
            Found = AnAuthor.Find(AuthorNo);
            if(AnAuthor.DOB != Convert.ToDateTime("16/9/2015")){
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindAuthorIsDeadOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AuthorNo = 1;
            Found = AnAuthor.Find(AuthorNo);
            if(AnAuthor.IsDead != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    }
}
