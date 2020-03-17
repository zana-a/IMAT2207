using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolioClasses.UserManagement;

namespace FolioTesting.UserManagement
{
    [TestClass]
    public class tstCustomerUserValidate
    {
        // Good Test Data
        // Some test data to pass to the valid method
        string fullname = "Barry Bones";
        string password = "pass123";
        string dob = Convert.ToDateTime("08/04/1999").ToString();
        string email = "someone@email.com";
        string telephone = "+447900000000";
        string numOfBooksBought = "123";

        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomerUser aclsCustomerUser = new clsCustomerUser();
            String error = "";
            error = aclsCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            Assert.AreEqual(error, "");
        }
    }
}
