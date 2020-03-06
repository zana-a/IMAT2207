using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolioClasses.AuthorManagement
{
    public class ClsAuthor
    {
        private Int32 mAuthorId;
        public Int32 Id
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
            mAuthorId = 1;
            mName = "Philip K. Dick";
            mDOB = Convert.ToDateTime("16/9/2015");
            mIsDead = true;
            //always return true
            return true;
        }
    }
}