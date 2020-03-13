using System;
using FolioClasses.BookManage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.BookManage
{
    [TestClass]
    public class tstBookManageFind
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Assert.IsNotNull(ABook);
        }
        [TestMethod]
        public void BookIDOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Int32 TestData = 1;
            ABook.BID = TestData;
            Assert.AreEqual(ABook.BID, TestData);
        }
        [TestMethod]
        public void AuthorIDOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Int32 TestData = 1;
            ABook.AID = TestData;
            Assert.AreEqual(ABook.AID, TestData);
        }
        [TestMethod]
        public void BookTitleOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            String TestData = "";
            ABook.BT = TestData;
            Assert.AreEqual(ABook.BT, TestData);
        }
        [TestMethod]
        public void BookPriceOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            double TestData = 11.11;
            ABook.BP = TestData;
            Assert.AreEqual(ABook.BP, TestData);
        }
        [TestMethod]
        public void BookTypeOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            String TestData = "";
            ABook.BTy = TestData;
            Assert.AreEqual(ABook.BTy, TestData);
        }
        [TestMethod]
        public void BookGenreOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            String TestData = "";
            ABook.BG = TestData;
            Assert.AreEqual(ABook.BG, TestData);
        }
        [TestMethod]
        public void BookPubDateOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            DateTime TestData = DateTime.Now.Date;
            ABook.BPD = TestData;
            Assert.AreEqual(ABook.BPD, TestData);
        }
        [TestMethod]
        public void BookFirstEditionOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Boolean TestData = true;
            ABook.FE = TestData;
            Assert.AreEqual(ABook.FE, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Boolean Found = false;
            Int32 BookID = 2;
            Found = ABook.Find(BookID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindBookIDOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookID = 2;
            Found = ABook.Find(BookID);

            if (ABook.BID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindBookPubDateOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookID = 2;
            Found = ABook.Find(BookID);
            if (ABook.BPD != Convert.ToDateTime("01/01/1980"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindBookFirstEditionOK()
        {
            clsBookDatabase ABook = new clsBookDatabase();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookID = 2;
            Found = ABook.Find(BookID);
            if (ABook.FE != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
