using System;
using System.Collections.Generic;

namespace FolioClasses.UserManagement
{
    public class clsCustomerUserCollection
    {
        private List<clsCustomerUser> mCustomerUserList;
        public List<clsCustomerUser> CustomerUserList
        {
            get
            {
                return mCustomerUserList;
            }
            set
            {

                mCustomerUserList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerUserList.Count;
            }
            set
            {
                // worry about it later he says
            }
        }

        clsCustomerUser mThisCustomerUser = new clsCustomerUser();
        public clsCustomerUser thisCustomerUser
        {
            get
            {
                return mThisCustomerUser;
            }
            set
            {
                mThisCustomerUser = value;
            }
        }

        public clsCustomerUserCollection()
        {
            mCustomerUserList = new List<clsCustomerUser>();

            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection db = new clsDataConnection();
            db.Execute("sproc_tblCustomerUser_SelectAll");
            recordCount = db.Count;

            while (index < recordCount)
            {
                clsCustomerUser aCustomerUser = new clsCustomerUser();
                aCustomerUser.UserId = Convert.ToInt32(db.DataTable.Rows[index]["user_id"]);
                aCustomerUser.Fullname = Convert.ToString(db.DataTable.Rows[index]["user_fullname"]);
                aCustomerUser.Password = Convert.ToString(db.DataTable.Rows[index]["user_password"]);
                aCustomerUser.Dob = Convert.ToDateTime(db.DataTable.Rows[index]["user_dob"]);
                aCustomerUser.Email = Convert.ToString(db.DataTable.Rows[index]["user_email"]);
                aCustomerUser.Telephone = Convert.ToString(db.DataTable.Rows[index]["user_telephone"]);
                aCustomerUser.NumOfBooksBought = Convert.ToInt32(db.DataTable.Rows[index]["user_numof_books_bought"]);
                aCustomerUser.IsEmailVerified = Convert.ToBoolean(db.DataTable.Rows[index]["user_is_email_verified"]);
                mCustomerUserList.Add(aCustomerUser);
                index++;
            }
        }

        public void Update()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@UserId", mThisCustomerUser.UserId);
            db.AddParameter("@Fullname", mThisCustomerUser.Fullname);
            db.AddParameter("@Password", mThisCustomerUser.Password);
            db.AddParameter("@Dob", mThisCustomerUser.Dob);
            db.AddParameter("@Email", mThisCustomerUser.Email);
            db.AddParameter("@Telephone", mThisCustomerUser.Telephone);
            db.AddParameter("@NumOfBooksBought", mThisCustomerUser.NumOfBooksBought);
            db.AddParameter("@IsEmailVerified", mThisCustomerUser.IsEmailVerified);

            db.Execute("sproc_tblCustomerUser_Update");
        }

        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@UserId", mThisCustomerUser.UserId);
            db.Execute("sproc_tblCustomerUser_Delete");
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@Fullname", mThisCustomerUser.Fullname);
            db.AddParameter("@Password", mThisCustomerUser.Password);
            db.AddParameter("@Dob", mThisCustomerUser.Dob);
            db.AddParameter("@Email", mThisCustomerUser.Email);
            db.AddParameter("@Telephone", mThisCustomerUser.Telephone);
            db.AddParameter("@NumOfBooksBought", mThisCustomerUser.NumOfBooksBought);
            db.AddParameter("@IsEmailVerified", mThisCustomerUser.IsEmailVerified);

            return db.Execute("sproc_tblCustomerUser_Insert");
        }
    }
}
