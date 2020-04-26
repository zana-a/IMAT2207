using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolioClasses.UserManagement;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserFilter
    {
        [TestMethod]
        public void ReportByFullnameMethodOk()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            clsCustomerUserCollection filteredCustomers = new clsCustomerUserCollection();

            filteredCustomers.ReportByFullname("");
            Assert.AreEqual(allCustomers.Count, filteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullnameNoneFound()
        {
            clsCustomerUserCollection filteredCustomers = new clsCustomerUserCollection();

            filteredCustomers.ReportByFullname("lkjljdasdlk");
            Assert.AreEqual(0, filteredCustomers.Count);
        }

        //[TestMethod]
        //public void ReportByFullnameTestDataFound()
        //{
        //    clsCustomerUserCollection filteredCustomers = new clsCustomerUserCollection();
        //
        //    Boolean Ok = true;
        //    filteredCustomers.ReportByFullname("???");
        //    if (filteredCustomers.Count == 2)
        //    {
        //        if (filteredCustomers.CustomerUserList[0].UserId != 36)
        //        {
        //            Ok = false;
        //        }
        //
        //        if (filteredCustomers.CustomerUserList[0].UserId != 37)
        //        {
        //            Ok = false;
        //        }
        //    }
        //    else
        //    {
        //        Ok = false;
        //    }
        //
        //    Assert.IsTrue(Ok);
        //}
    }
}
