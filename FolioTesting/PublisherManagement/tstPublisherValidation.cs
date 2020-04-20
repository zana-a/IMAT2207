using System;
using FolioClasses.PublisherManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.PublisherManagement
{
    [TestClass]
    public class tstPublisherValidation
    {
        // "Good" test data"
        string publisherId = "123";
        string publisherName = "Some Publisher";
        string publisherDateFounded = DateTime.Now.Date.ToString();
        string publisherWebsite = "www.testPublisher.com";

        [TestMethod]
        public void PublisherIdValidMethodOK()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            Error = aPublisher.PublisherIdValid(publisherId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameValidMethodOK()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherDateFoundedValidMethodOK()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            Error = aPublisher.PublisherDateFoundedValid(publisherDateFounded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherWebsiteValidMethodOK()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            Error = aPublisher.PublisherWebsiteValid(publisherWebsite);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublisherIdMin()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherId = "1";
            Error = aPublisher.PublisherIdValid(publisherId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherIdMinPlusOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherId = "11";
            Error = aPublisher.PublisherIdValid(publisherId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherIdMax()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherId = "1234567891234567891234567";
            Error = aPublisher.PublisherIdValid(publisherId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherIdMaxPlusOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherId = "12345678912345678912345678";
            Error = aPublisher.PublisherIdValid(publisherId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherIdMaxLessOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherId = "123456789123456789123456";
            Error = aPublisher.PublisherIdValid(publisherId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublisherNameMin()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "a";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameMinLessOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameMinPlusOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "aa";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameMax()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameMaxLessOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaa";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameMaxPlusOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaaaaaaaa";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameMid()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "aaaaaaaaaa" +
                                "aaaaaaaaaa" +
                                "aaaaa";
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherNameExtremeMax()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherName = "";
            publisherName = publisherName.PadRight(500, 'a');
            Error = aPublisher.PublisherNameValid(publisherName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublisherDateFoundedMax()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            DateTime TestDate;
            TestDate = new DateTime(1500, 01, 01);
            string publisherDateFounded = TestDate.ToString();
            Error = aPublisher.PublisherDateFoundedValid(publisherDateFounded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherDateFoundedMin()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // Going off the basis that the youngest publisher in the world was 4 years old.
            TestDate = TestDate.AddYears(-4);
            string publisherDateFounded = TestDate.ToString();
            Error = aPublisher.PublisherDateFoundedValid(publisherDateFounded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherDateFoundedFuture()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddHours(1);
            string publisherDateFounded = TestDate.ToString();
            Error = aPublisher.PublisherDateFoundedValid(publisherDateFounded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherDateFoundedExtremeMax()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);
            string publisherDateFounded = TestDate.ToString();
            Error = aPublisher.PublisherDateFoundedValid(publisherDateFounded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherDateFoundedInvalidData()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherDateFounded = "this is not a date";
            Error = aPublisher.PublisherDateFoundedValid(publisherDateFounded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublisherWebsiteMin()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherWebsite = "p";
            Error = aPublisher.PublisherWebsiteValid(publisherWebsite);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherWebsiteMinLessOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherWebsite = "";
            Error = aPublisher.PublisherWebsiteValid(publisherWebsite);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherWebsiteMax()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherWebsite = "";
            publisherWebsite = publisherWebsite.PadRight(255, 'p');
            Error = aPublisher.PublisherWebsiteValid(publisherWebsite);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherWebsiteMaxPlusOne()
        {
            ClsPublisher aPublisher = new ClsPublisher();
            String Error = "";
            string publisherWebsite = "";
            publisherWebsite = publisherWebsite.PadRight(256, 'p');
            Error = aPublisher.PublisherWebsiteValid(publisherWebsite);
            Assert.AreNotEqual(Error, "");
        }
    }
}

