﻿using System;
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
        public void PublisherDateFoundedOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            DateTime TestData = DateTime.Now.Date;
            APublisher.DateFounded = TestData;
            Assert.AreEqual(APublisher.DateFounded, TestData);
        }
        [TestMethod]
        public void PublisherIsActiveOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean TestData = true;
            APublisher.IsActive = TestData;
            Assert.AreEqual(APublisher.IsActive, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Int32 PublisherNo = 5;
            Found = APublisher.Find(PublisherNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindPublisherIdOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 5;
            Found = APublisher.Find(PublisherNo);

            if(APublisher.PublisherId != PublisherNo)
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
            Int32 PublisherNo = 5;
            Found = APublisher.Find(PublisherNo);
            if(APublisher.Name != "Penguin Books")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindPublisherDateFoundedOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 5;
            Found = APublisher.Find(PublisherNo);
            if(APublisher.DateFounded != Convert.ToDateTime("01/01/1935")){
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindPublisherIsActiveOK()
        {
            ClsPublisher APublisher = new ClsPublisher();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PublisherNo = 5;
            Found = APublisher.Find(PublisherNo);
            if(APublisher.IsActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    }
}
