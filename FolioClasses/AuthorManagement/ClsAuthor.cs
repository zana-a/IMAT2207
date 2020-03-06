﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolioClasses.AuthorManagement
{
    public class ClsAuthor
    {
        private Int32 mAuthorId;
        public Int32 AuthorId
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
        private bool mIsDead;
        public bool IsDead
        {
            get
            {
                return mIsDead;
            }
            set
            {
                mIsDead = value;
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
        public bool Find(int AuthorNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AuthorId", AuthorId);
            DB.Execute("sproc_tblAuthorManage_FilterByAuthorId");
            if(DB.Count == 1)
            {
                mAuthorId = Convert.ToInt32(DB.DataTable.Rows[0]["author_id"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["author_name"]);
                mIsDead = Convert.ToBoolean(DB.DataTable.Rows[0]["author_isalive"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["author_dob"]);
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}