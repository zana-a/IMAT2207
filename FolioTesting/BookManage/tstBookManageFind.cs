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
            clsBook ABook = new clsBook();
            Assert.IsNotNull(ABook);
        }
        [TestMethod]
        public void BookIDOK()
        {
            clsBook ABook = new clsBook();
            Int32 TestData = 1;
            ABook.BID = TestData;
            Assert.AreEqual(ABook.BID, TestData);
        }
        [TestMethod]
        public void AuthorIDOK()
        {
            clsBook ABook = new clsBook();
            Int32 TestData = 1;
            ABook.AID = TestData;
            Assert.AreEqual(ABook.AID, TestData);
        }
        [TestMethod]
        public void BookTitleOK()
        {
            clsBook ABook = new clsBook();
            String TestData = "";
            ABook.BT = TestData;
            Assert.AreEqual(ABook.BT, TestData);
        }
        [TestMethod]
        public void BookPriceOK()
        {
            clsBook ABook = new clsBook();
            double TestData = 11.11;
            ABook.BP = TestData;
            Assert.AreEqual(ABook.BP, TestData);
        }
        [TestMethod]
        public void BookTypeOK()
        {
            clsBook ABook = new clsBook();
            String TestData = "";
            ABook.BTy = TestData;
            Assert.AreEqual(ABook.BTy, TestData);
        }
        [TestMethod]
        public void BookGenreOK()
        {
            clsBook ABook = new clsBook();
            String TestData = "";
            ABook.BG = TestData;
            Assert.AreEqual(ABook.BG, TestData);
        }
        [TestMethod]
        public void BookPubDateOK()
        {
            clsBook ABook = new clsBook();
            DateTime TestData = DateTime.Now.Date;
            ABook.BPD = TestData;
            Assert.AreEqual(ABook.BPD, TestData);
        }
        [TestMethod]
        public void BookFirstEditionOK()
        {
            clsBook ABook = new clsBook();
            Boolean TestData = true;
            ABook.FE = TestData;
            Assert.AreEqual(ABook.FE, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsBook ABook = new clsBook();
            Boolean Found = false;
            Int32 BookID = 2;
            Found = ABook.Find(BookID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindBookIDOK()
        {
            clsBook ABook = new clsBook();
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
            clsBook ABook = new clsBook();
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
        public void FinDBookFirstEditionOK()
        {
            clsBook ABook = new clsBook();
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
