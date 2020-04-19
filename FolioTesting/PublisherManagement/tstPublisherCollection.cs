using System;
using System.Collections.Generic;
using FolioClasses.PublisherManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.PublisherManagement
{
    [TestClass]
    public class tstPublisherCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            Assert.IsNotNull(AllPublishers);
        }
        [TestMethod]
        public void PublisherListOK()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            List<ClsPublisher> PublisherTestList = new List<ClsPublisher>();
            ClsPublisher TestPublisher = new ClsPublisher();

            TestPublisher.PublisherId = 1;            
            TestPublisher.Name = "Some Publisher";
            TestPublisher.DateFounded = new DateTime(1950, 09, 09);
            TestPublisher.IsActive = true;
            TestPublisher.Website = "www.somepublisher.co.uk";
            PublisherTestList.Add(TestPublisher);
            AllPublishers.PublisherList = PublisherTestList;
            Assert.AreEqual(AllPublishers.PublisherList, PublisherTestList);
        }
        [TestMethod]
        public void ThisPublisherPropertyOK()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            ClsPublisher TestPublisher = new ClsPublisher();
            TestPublisher.PublisherId = 1;
            TestPublisher.Name = "Some Publisher";
            TestPublisher.DateFounded = new DateTime(1950, 09, 09);
            TestPublisher.IsActive = true;
            TestPublisher.Website = "www.somepublisher.co.uk";
            AllPublishers.ThisPublisher = TestPublisher;
            Assert.AreEqual(AllPublishers.ThisPublisher, TestPublisher);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            List<ClsPublisher> PublisherTestList = new List<ClsPublisher>();
            ClsPublisher TestPublisher = new ClsPublisher();
            TestPublisher.PublisherId = 1;
            TestPublisher.Name = "Some Publisher";
            TestPublisher.DateFounded = new DateTime(1950, 09, 09);
            TestPublisher.IsActive = true;
            TestPublisher.Website = "www.somepublisher.co.uk";
            PublisherTestList.Add(TestPublisher);
            AllPublishers.PublisherList = PublisherTestList;
            Assert.AreEqual(AllPublishers.Count, PublisherTestList.Count);
        }
    }
}
