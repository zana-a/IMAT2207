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
    }
}