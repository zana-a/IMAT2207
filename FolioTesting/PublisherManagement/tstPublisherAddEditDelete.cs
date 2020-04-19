using System;
using FolioClasses.PublisherManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.PublisherManagement
{
    [TestClass]
    public class tstPublisherAddEditDelete
    {
        [TestMethod]
        public void AddMethodOK()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            ClsPublisher APublisher = new ClsPublisher();
            Int32 PrimaryKey = 0;
            APublisher.Name = "Add Test Publisher";
            APublisher.DateFounded = new DateTime(1950, 01, 01);
            APublisher.IsActive = false;
            APublisher.Website = "www.aPublisher.co.uk";
            AllPublishers.ThisPublisher = APublisher;
            PrimaryKey = AllPublishers.Add();
            APublisher.PublisherId = PrimaryKey;
            AllPublishers.ThisPublisher.Find(PrimaryKey);
            Assert.AreEqual(AllPublishers.ThisPublisher, APublisher);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            ClsPublisher APublisher = new ClsPublisher();
            Int32 PrimaryKey = 0;
            APublisher.Name = " Delete Test Publisher";
            APublisher.DateFounded = new DateTime(1950, 01, 01);
            APublisher.IsActive = false;
            APublisher.Website = "www.aPublisher.co.uk";
            AllPublishers.ThisPublisher = APublisher;
            PrimaryKey = AllPublishers.Add();
            APublisher.PublisherId = PrimaryKey;
            AllPublishers.ThisPublisher.Find(PrimaryKey);
            AllPublishers.Delete();
            Boolean Found = AllPublishers.ThisPublisher.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            ClsPublisherCollection AllPublishers = new ClsPublisherCollection();
            ClsPublisher APublisher = new ClsPublisher();
            Int32 PrimaryKey = 0;
            APublisher.Name = "Update Test Publisher";
            APublisher.DateFounded = new DateTime(1888, 02, 04);
            APublisher.IsActive = false;
            APublisher.Website = "www.aPublisher.co.uk";
            AllPublishers.ThisPublisher = APublisher;
            PrimaryKey = AllPublishers.Add();
            APublisher.PublisherId = PrimaryKey;
            APublisher.Name = "Update Test Publisher Two";
            APublisher.DateFounded = new DateTime(1988, 02, 04);
            APublisher.IsActive = true;
            APublisher.Website = "www.TwoPublisher.co.uk";
            AllPublishers.ThisPublisher = APublisher;
            AllPublishers.Update();
            AllPublishers.ThisPublisher.Find(PrimaryKey);
            Assert.AreEqual(AllPublishers.ThisPublisher, APublisher);
        }
    }
}
