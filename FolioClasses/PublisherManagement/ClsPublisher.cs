using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolioClasses.PublisherManagement
{
    public class ClsPublisher
    {
        private Int32 mPublisherId;
        public Int32 PublisherId
        {
            get
            {
                return mPublisherId;
            }
            set
            {
                mPublisherId = value;
            }
        }
        private bool mIsActive;
        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }
        private DateTime mDateFounded;
        public DateTime DateFounded
        {
            get
            {
                return mDateFounded;
            }
            set
            {
                mDateFounded = value;
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
        private String mWebsite;
        public String Website
        {
            get
            {
                return mWebsite;
            }
            set
            {
                mWebsite = value;
            }
        }
        public bool Find(int PublisherNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PublisherId", PublisherId);
            DB.Execute("sproc_tblpublisherManage_FilterBypublisherId");
            if(DB.Count == 1)
            {
                mPublisherId = Convert.ToInt32(DB.DataTable.Rows[0]["publisher_id"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["publisher_name"]);
                mDateFounded = Convert.ToDateTime(DB.DataTable.Rows[0]["publisher_datefounded"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["publisher_isactive"]);
                mWebsite = Convert.ToString(DB.DataTable.Rows[0]["publisher_website"]);
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}