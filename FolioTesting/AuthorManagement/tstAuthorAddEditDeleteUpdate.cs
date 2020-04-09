using System;
using FolioClasses;
using FolioClasses.AuthorManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.AuthorManagement
{
    [TestClass]
    public class tstAuthorAddEditDeleteUpdate
    {
        [TestMethod]
        public void AddMethodOK()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            ClsAuthor AnAuthor = new ClsAuthor();
            Int32 PrimaryKey = 0;
            AnAuthor.AuthorId = 1;
            AnAuthor.Name = "Test Author";
            AnAuthor.DOB = new DateTime(1950, 01, 01);
            AnAuthor.IsAlive = false;
            AllAuthors.ThisAuthor = AnAuthor;
            PrimaryKey = AllAuthors.Add();
            AnAuthor.AuthorId = PrimaryKey;
            AllAuthors.ThisAuthor.Find(PrimaryKey);
            Assert.AreEqual(AllAuthors.ThisAuthor, AnAuthor);
        }
    }
}
