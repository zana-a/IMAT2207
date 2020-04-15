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
            AnAuthor.Name = "Add Test Author";
            AnAuthor.DOB = new DateTime(1950, 01, 01);
            AnAuthor.IsAlive = false;
            AllAuthors.ThisAuthor = AnAuthor;
            PrimaryKey = AllAuthors.Add();
            AnAuthor.AuthorId = PrimaryKey;
            AllAuthors.ThisAuthor.Find(PrimaryKey);
            Assert.AreEqual(AllAuthors.ThisAuthor, AnAuthor);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            ClsAuthor AnAuthor = new ClsAuthor();
            Int32 PrimaryKey = 0;
            AnAuthor.Name = " Delete Test Author";
            AnAuthor.DOB = new DateTime(1950, 01, 01);
            AnAuthor.IsAlive = false;
            AllAuthors.ThisAuthor = AnAuthor;
            PrimaryKey = AllAuthors.Add();
            AnAuthor.AuthorId = PrimaryKey;
            AllAuthors.ThisAuthor.Find(PrimaryKey);
            AllAuthors.Delete();
            Boolean Found = AllAuthors.ThisAuthor.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            ClsAuthor AnAuthor = new ClsAuthor();
            Int32 PrimaryKey = 0;
            AnAuthor.Name = "Update Test Author";
            AnAuthor.DOB = new DateTime(1888, 02, 04);
            AnAuthor.IsAlive = false;
            AllAuthors.ThisAuthor = AnAuthor;
            PrimaryKey = AllAuthors.Add();
            AnAuthor.AuthorId = PrimaryKey;
            AnAuthor.Name = "Update Test Author Two";
            AnAuthor.DOB = new DateTime(1988, 02, 04);
            AnAuthor.IsAlive = true;
            AllAuthors.ThisAuthor = AnAuthor;
            AllAuthors.Update();
            AllAuthors.ThisAuthor.Find(PrimaryKey);
            Assert.AreEqual(AllAuthors.ThisAuthor, AnAuthor);
        }
    }
}
