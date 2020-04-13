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

        public clsCustomerUser thisCustomerUser { get; set; }

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

        //public int Add()
        //{
        //    clsDataConnection DB = new clsDataConnection();
        //    DB.AddParameter("@AuthorId", mThisAuthor.AuthorId);
        //    DB.AddParameter("@Name", mThisAuthor.Name);
        //    DB.AddParameter("@Dob", mThisAuthor.DOB);
        //    DB.AddParameter("@IsAlive", mThisAuthor.IsAlive);
        //    return DB.Execute("sproc_tblAuthorManage_Insert");
        //}
    }
}
