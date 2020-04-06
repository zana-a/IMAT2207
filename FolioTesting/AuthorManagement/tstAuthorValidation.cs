using System;
using FolioClasses.AuthorManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.AuthorManagement
{
    [TestClass]
    public class tstAuthorValidation
    {   // "Good" test data"
        string authorName = "Some Author";
        string authorDob = DateTime.Now.Date.ToString();

        [TestMethod]
        public void AuthorNameValidMethodOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorDobValidMethodOK()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            Error = AnAuthor.AuthorDobValid(authorDob);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMin()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "a";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMinLessOne()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMinPlusOne()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "aa";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMax()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMaxLessOne()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaa";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMaxPlusOne()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaaa";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMid()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaa";
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameExtremeMax()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorName = "";
            authorName = authorName.PadRight(500, 'a');
            Error = AnAuthor.AuthorNameValid(authorName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorDobMax()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            DateTime TestDate;
            TestDate = new DateTime(1500, 01, 01);
            string authorDob = TestDate.ToString();
            Error = AnAuthor.AuthorDobValid(authorDob);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorDobMin()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // Going off the basis that the youngest author in the world was 4 years old.
            TestDate = TestDate.AddYears(-5);
            string authorDob = TestDate.ToString();
            Error = AnAuthor.AuthorDobValid(authorDob);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorDobFuture()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddHours(1);
            string authorDob = TestDate.ToString();
            Error = AnAuthor.AuthorDobValid(authorDob);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorDobExtremeMax()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);
            string authorDob = TestDate.ToString();
            Error = AnAuthor.AuthorDobValid(authorDob);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorDobInvalidData()
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            String Error = "";
            string authorDob = "this is not a date";
            Error = AnAuthor.AuthorDobValid(authorDob);
            Assert.AreNotEqual(Error, "");
        }
    }
}
