using System;
using System.Collections.Generic;
using FolioClasses;
using FolioClasses.AuthorManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.AuthorManagement
{
    [TestClass]
    public class tstAuthorCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            Assert.IsNotNull(AllAuthors);
        }
        [TestMethod]
        public void AuthorListOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            List<ClsAuthor> AuthorTestList = new List<ClsAuthor>();
            ClsAuthor TestAuthor = new ClsAuthor();

            TestAuthor.AuthorId = 1;
            TestAuthor.IsAlive = true;
            TestAuthor.Name = "Some Author";

            AuthorTestList.Add(TestAuthor);
            AllAuthors.AuthorList = AuthorTestList;
            Assert.AreEqual(AllAuthors.AuthorList, AuthorTestList);
        }
        [TestMethod]
        public void CountAuthorOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            Int32 SomeCount = 0;
            AllAuthors.Count = SomeCount;
            Assert.AreEqual(AllAuthors.Count, SomeCount);
        }
        [TestMethod]
        public void ThisAuthorPropertyOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            ClsAuthor TestAuthor = new ClsAuthor();
            TestAuthor.AuthorId = 1;
            TestAuthor.Name = "Some Author";
            TestAuthor.IsAlive = true;
            AllAuthors.ThisAuthor = TestAuthor;
            Assert.AreEqual(AllAuthors.ThisAuthor, TestAuthor);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            List<ClsAuthor> AuthorTestList = new List<ClsAuthor>();
            ClsAuthor TestAuthor = new ClsAuthor();
            TestAuthor.AuthorId = 1;
            TestAuthor.Name = "Some Author";
            TestAuthor.IsAlive = true;
            AuthorTestList.Add(TestAuthor);
            AllAuthors.AuthorList = AuthorTestList;
            Assert.AreEqual(AllAuthors.Count, AuthorTestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            Assert.AreEqual(AllAuthors.Count, 2);
        }
    }
}

