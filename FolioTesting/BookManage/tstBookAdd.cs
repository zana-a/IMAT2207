using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolioClasses.BookManage;
using System.Collections.Generic;

namespace FolioTesting.BookManage
{
    [TestClass]
    public class tstBookAdd
    {
        [TestMethod]
        public void AddMethodOK()
        {
            clsBookCollection allBooks = new clsBookCollection();
            List<clsBookDatabase> testList = new List<clsBookDatabase>();

            Int32 primaryKey = 0;

            clsBookDatabase testItem = new clsBookDatabase();
            testItem.BID = 1;
            testItem.AID = 1;
            testItem.BT = "A Good Book";
            testItem.BP = 9.99;
            testItem.BTy = "Hardbook";
            testItem.BG = "Sci-Fi";
            testItem.BPD = Convert.ToDateTime("24/04/1999");
            testItem.FE = true;

            allBooks.thisBook = testItem;

            primaryKey = allBooks.Add();
            testItem.BID = primaryKey;

            allBooks.thisBook.Find(primaryKey);
            Assert.AreEqual(allBooks.thisBook, testItem);
        }
    }
}
