using System;
using FolioClasses.PublisherManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.PublisherManagement
{
    [TestClass]
    public class tstPublisher
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Assert.IsNotNull(APublisher);
        }
        [TestMethod]
        public void PublisherIdOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Int32 TestData = 1;
            APublisher.PublisherId = TestData;
            Assert.AreEqual(APublisher.PublisherId, TestData);
        }
        [TestMethod]
        public void PublisherNameOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            String TestData = "";
            APublisher.Name = TestData;
            Assert.AreEqual(APublisher.Name, TestData);
        }
        [TestMethod]
        public void PublisherDOBOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            DateTime TestData = DateTime.Now.Date;
            APublisher.DOB = TestData;
            Assert.AreEqual(APublisher.DOB, TestData);
        }
        [TestMethod]
        public void PublisherIsDeadOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean TestData = true;
            APublisher.IsDead = TestData;
            Assert.AreEqual(APublisher.IsDead, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Int32 PublisherNo = 1;
            Found = APublisher.Find(PublisherNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindPublisherIdOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 1;
            Found = APublisher.Find(PublisherNo);

            if(APublisher.PublisherId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindPublisherNameOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 1;
            Found = APublisher.Find(PublisherNo);
            if(APublisher.Name != "Philip K. Dick")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindPublisherDOBOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 1;
            Found = APublisher.Find(PublisherNo);
            if(APublisher.DOB != Convert.ToDateTime("16/9/2015")){
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindPublisherIsDeadOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 1;
            Found = APublisher.Find(PublisherNo);
            if(APublisher.IsDead != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    }
}
