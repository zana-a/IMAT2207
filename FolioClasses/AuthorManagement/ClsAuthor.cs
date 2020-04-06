using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolioClasses.AuthorManagement
{
    public class ClsAuthor
    {
        private int mAuthorId;
        public int AuthorId
        {
            get
            {
                return mAuthorId;
            }
            set
            {
                mAuthorId = value;
            }
        }
        private bool mIsAlive;
        public bool IsAlive
        {
            get
            {
                return mIsAlive;
            }
            set
            {
                mIsAlive = value;
            }
        }
        private DateTime mDOB;
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        private String mName;
        public String Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public bool Find(int id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AuthorId", id);
            DB.Execute("sproc_tblAuthorManage_FilterByAuthorId");
            if(DB.Count == 1)
            {
                mAuthorId = Convert.ToInt32(DB.DataTable.Rows[0]["author_id"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["author_name"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["author_dob"]);
                mIsAlive = Convert.ToBoolean(DB.DataTable.Rows[0]["author_isalive"]);                
                return true;

            }
            else
            {
                return false;
            }
        }
        /* I have seperated my validation classes so I can
            add errors to specific text fields more easily */
        public string AuthorNameValid(string authorName)
        {
            String Error = "";
            if(authorName.Length == 0)
            {
                Error += "The author name field may not be blank ";
            }
            if (authorName.Length > 50)
            {
                Error += "The author name field may not be longer than 50 characters";
            }
            return Error;
        }
        public string AuthorDobValid(string authorDob)
        {
            String Error = "";
            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(authorDob);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future ";
                }
                if (DateTemp > DateTime.Now.Date.AddYears(-4).AddDays(-365).AddHours(-23).AddMinutes(59) && DateTemp < DateTime.Now.Date)
                {
                    Error += "The date cannot be less than 5 years before today";
                }
                if (DateTemp < new DateTime(1500, 01, 01))
                {
                    // Not because authors did not exist before then, but a limit must be somewhere
                    Error += "The author cannot be born before 01/01/1500";
                }
            }
            catch
            {
                Error += "The date entered is not a valid date";
            }
            return Error;
        }

    }
}