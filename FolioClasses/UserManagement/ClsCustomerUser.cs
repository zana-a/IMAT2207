using System;

namespace FolioClasses.UserManagement
{
    public class clsCustomerUser
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

        // string userId handled by data layer
        public string Valid(
            string fullname,
            string password,
            string dob,
            string email,
            string telephone,
            string numOfBooksBought)
        {
            //create a string variable to store the error
            String Error = "";


            /*
             * Full Name Validation
             */
            if (fullname.Length == 0)
            {
                Error += "FullName should not be empty.";
            }

            if (fullname.Length < 4)
            {
                Error += "FullName should not be less than 4 characters.";
            }

            if (fullname.Length > 30)
            {
                Error += "FullName should not be greater than 30 characters.";
            }

            /*
             * Password Validation
             */
            if (password.Length == 0)
            {
                Error += "Email should not be empty.";
            }

            if (password.Length < 5)
            {
                Error += "Password should not be less than 5 characters.";
            }

            if (password.Length > 30)
            {
                Error += "Password should not be greater than 30 characters.";
            }

            /*
             * Dob Validation
             */
            DateTime tempDate = DateTime.Now.Date;

            if (Convert.ToDateTime(dob) < tempDate.AddYears(-100))  
            {
                Error += "Date of Birth should not be older than 100 years.";
            }

            if (Convert.ToDateTime(dob) > tempDate)
            {
                Error += "Date of Birth should not exceed current date.";
            }

            if (Convert.ToDateTime(dob) > tempDate.AddYears(-18)) 
            {
                Error += "Age restriction. Must be at last 18 years old.";
            }

            /*
             * Email Validation
             */
            if (email.Length == 0)
            {
                Error += "Email should not be empty.";
            }

            if (email.Length < 5)
            {
                Error += "Password should not be less than 5 characters.";
            }
            
            if (!email.Contains("@"))
            {
                Error += "Email is not a valid input. Must contain @.";
            }

            if (email.Length > 50)
            {
                Error += "Email should not be greater than 30 characters.";
            }

            /*
             * Telephone Validation
             */
            if (telephone.Length == 0)
            {
                Error += "Telephone should not be empty.";
            }

            if (!telephone.Contains("+"))
            {
                Error += "Telephone input not a valid input. Must contain +.";
            }

            if (telephone.Length > 15)
            {
                Error += "Telephone input should not be greater than 15 characters.";
            }

            if (telephone.Length < 10)
            {
                Error += "Telephone input should not be greater than 15 characters.";
            }

            if (email.Length > 50)
            {
                Error += "Email should not be greater than 30 characters.";
            }

            /*
             * NumOfBooksBought Validation 
             */
            Int32 tempNumOfBooksBought;

            if (!Int32.TryParse(numOfBooksBought, out tempNumOfBooksBought))
            {
                Error += "Number of Books Bought field contains invalid characters or above range";
            }

            if (Int32.TryParse(numOfBooksBought, out tempNumOfBooksBought) && tempNumOfBooksBought < 0)
            {
                Error += "Number of Books Bought cannot be less than 0";
            }

            //return any error messages
            return Error;
        }
    }
}
