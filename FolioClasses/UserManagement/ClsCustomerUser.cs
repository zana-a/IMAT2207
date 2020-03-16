using System;

namespace FolioClasses.UserManagement
{
    public class CustomerUser
    {
        private int mUserId;
        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }

        private string mFullname;
        public string Fullname
        {
            get
            {
                return mFullname;
            }
            set
            {
                mFullname = value;
            }
        }

        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        private DateTime mDob;
        public DateTime Dob
        {
            get
            {
                return mDob;
            }
            set
            {
                mDob = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private string mTelephone;
        public string Telephone
        {
            get
            {
                return mTelephone;
            }
            set
            {
                mTelephone = value;
            }
        }

        private int mNumOfBooksBought;
        public int NumOfBooksBought
        {
            get
            {
                return mNumOfBooksBought;
            }
            set
            {
                mNumOfBooksBought = value;
            }
        }

        private bool mIsEmailVerified;
        public bool IsEmailVerified
        {
            get
            {
                return mIsEmailVerified;
            }
            set
            {
                mIsEmailVerified = value;
            }
        }

        public bool Find(int id)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@UserId", id);
            db.Execute("sproc_tblCustomerUser_FilterByUserId");

            if (db.Count == 1)
            {
                mUserId = Convert.ToInt32(db.DataTable.Rows[0]["user_id"]);
                mFullname = Convert.ToString(db.DataTable.Rows[0]["user_fullname"]);
                mPassword = Convert.ToString(db.DataTable.Rows[0]["user_password"]);
                mDob = Convert.ToDateTime(db.DataTable.Rows[0]["user_dob"]);
                mEmail = Convert.ToString(db.DataTable.Rows[0]["user_email"]);
                mTelephone = Convert.ToString(db.DataTable.Rows[0]["user_telephone"]);
                mNumOfBooksBought = Convert.ToInt32(db.DataTable.Rows[0]["user_numof_books_bought"]);
                mIsEmailVerified = Convert.ToBoolean(db.DataTable.Rows[0]["user_is_email_verified"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        // string isEmailVerified missing
        // string userId handled by data layer
        public string Valid(
            string fullname,
            string password,
            string dob,
            string email,
            string telephone,
            string numOfBooksBought)
        {
            return "";
        }
    }
}
