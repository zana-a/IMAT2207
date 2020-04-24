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
        public void AddMethodOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            ClsAuthor TestAuthor = new ClsAuthor();
            Int32 PrimaryKey = 0;

            TestAuthor.AuthorId = 1;
            TestAuthor.Name = "Test Author";
            TestAuthor.DOB = DateTime.Now.Date;
            TestAuthor.Description = "An example description";
            TestAuthor.IsAlive = true;
            TestAuthor.ImagePath = "~/assets/images";
            AllAuthors.ThisAuthor = TestAuthor;
            PrimaryKey = AllAuthors.Add();
            TestAuthor.AuthorId = PrimaryKey;
            AllAuthors.ThisAuthor.Find(PrimaryKey);
            Assert.AreEqual(AllAuthors.ThisAuthor, TestAuthor);
        }
        [TestMethod]
        public void ReportByNameMethodOk()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            ClsAuthorCollection FilteredAuthors = new ClsAuthorCollection();
            FilteredAuthors.ReportByName("");
            Assert.AreEqual(AllAuthors.Count, FilteredAuthors.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            ClsAuthorCollection FilteredAuthors = new ClsAuthorCollection();
            FilteredAuthors.ReportByName("Xxxx");
            Assert.AreEqual(0, FilteredAuthors.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            ClsAuthorCollection FilteredAuthors = new ClsAuthorCollection();
            Boolean OK = true;
            FilteredAuthors.ReportByName("Test Author");
            if(FilteredAuthors.Count == 2)
            {
                if(FilteredAuthors.AuthorList[0].AuthorId != 34)
                {
                    OK = false;
                }
                if(FilteredAuthors.AuthorList[1].AuthorId != 35)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    }
}

