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
        String fullname = "Barry Bones";
        String password = "pass123";
        String dob = Convert.ToDateTime("08/04/1999").ToString();
        String email = "someone@email.com";
        String telephone = "+447900000000";
        String numOfBooksBought = "123";

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String fullname = "";

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String fullname = "a"; 

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String fullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            //create some test data to pass to the method
            String fullname = "aaa"; //this should be ok

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String fullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //31

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String fullname = "aaaaaaaaaaaaaaa"; //15

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String password = ""; //this should be ok

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String password = "a"; //this should be ok

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String password = "aaaaaaaaaaaaaa"; //14

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String password = "aaaaaaaaaaaaaaa"; // 15

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String password = "aaaaaaaaaaaaaaaa"; //16

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String password = "aaaaaaa"; //7

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(-100);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DobMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(-1);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(-100);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(-99);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(99);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMax()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(1);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMid()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            DateTime dob = DateTime.Now.Date;
            dob = dob.AddYears(-50);

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob.ToString(), email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String email = "";
            email = email.PadRight(5, 'a');

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String email = "";
            email = email.PadRight(6, 'a');

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String email = "";
            email = email.PadRight(49, 'a');

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String email = "";
            email = email.PadRight(50, 'a');

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String email = "";
            email = email.PadRight(51, 'a');

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String email = "";
            email = email.PadRight(25, 'a');

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String telephone = "";
            // does not inclide +44. should pass if + not present and total is all numbers
            telephone = telephone.PadRight(10, 'a'); 

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String telephone = "";
            telephone = telephone.PadRight(11, 'a'); // should error 

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String telephone = "";
            telephone = telephone.PadRight(12, 'a'); // should error

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMax()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String telephone = "";
            telephone = telephone.PadRight(13, 'a'); // should pass but must inclide + at the start of the String.

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String telephone = "";
            telephone = telephone.PadRight(14, 'a'); // should error

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMid()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            String telephone = "";
            telephone = telephone.PadRight(7, 'a'); // should error

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOfBooksBoughtMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            Int32 numOfBooksBought = -1; // should error

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOfBooksBoughtMin()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            Int32 numOfBooksBought = 0; // should pass

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOfBooksBoughtMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            Int32 numOfBooksBought = 1; // should pass

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOfBooksBoughtMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            Int32 numOfBooksBought = Int32.MaxValue - 1; // should pass

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumOfBooksBoughtMax()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            Int32 numOfBooksBought = Int32.MaxValue; // should error

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void NumOfBooksBoughtMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    Int32 numOfBooksBought = Int32.MaxValue + 1; // should error
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void NumOfBooksBoughtMid()
        {
            //create an instance of the class we want to create
            clsCustomerUser aCustomerUser = new clsCustomerUser();

            //String variable to store any error message
            String Error = "";

            Int32 numOfBooksBought = Int32.MaxValue / 2; // should pass

            //invoke the method
            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void IsEmailVerifiedMinLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    Int32 numOfBooksBought = Int32.MaxValue; // should error
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought.ToString());
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void IsEmailVerifiedMin()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    //create some test data to pass to the method
        //    String HouseNo = "aaa"; //this should be ok
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void IsEmailVerifiedMinPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    //create some test data to pass to the method
        //    String HouseNo = "aaa"; //this should be ok
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void IsEmailVerifiedMaxLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    //create some test data to pass to the method
        //    String HouseNo = "aaa"; //this should be ok
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void IsEmailVerifiedMax()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    //create some test data to pass to the method
        //    String HouseNo = "aaa"; //this should be ok
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void IsEmailVerifiedMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    //create some test data to pass to the method
        //    String HouseNo = "aaa"; //this should be ok
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void IsEmailVerifiedMid()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerUser aCustomerUser = new clsCustomerUser();
        //
        //    //String variable to store any error message
        //    String Error = "";
        //
        //    //create some test data to pass to the method
        //    String HouseNo = "aaa"; //this should be ok
        //
        //    //invoke the method
        //    Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //
        //[TestMethod]
        //public void ValidMethodOk()
        //{
        //    clsCustomerUser aclsCustomerUser = new clsCustomerUser();
        //    String error = "";
        //    error = aclsCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);
        //
        //    Assert.AreEqual(error, "");
        //}
    }
}
