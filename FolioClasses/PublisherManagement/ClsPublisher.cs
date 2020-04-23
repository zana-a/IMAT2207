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
        public bool Find(int id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PublisherId", id);
            DB.Execute("sproc_tblPublisherManage_FilterByPublisherId");
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
        public string PublisherIdValid(string publisherId)
        {
            String Error = "";
            if (publisherId.Length == 0)
            {
                Error += "The publisher ID field must not be blank";
            }
            if (publisherId.Length > 25)
            {
                Error += "The publisher ID field must not be longer than 25 characters";
            }
            // Not certain if the below expression works
            if (publisherId.Contains(@"[a-zA-Z]"))
            {
                Error += "The publisher ID field must not contain letters";
            }
            return Error;
        }
        public string PublisherNameValid(string publisherName)
        {
            String Error = "";
            if (publisherName.Length == 0)
            {
                Error += "The publisher name field must not be blank ";
            }
            if (publisherName.Length > 50)
            {
                Error += "The publisher name field must not be longer than 50 characters";
            }
            return Error;
        }
        public string PublisherWebsiteValid(string publisherWebsite)
        {
            String Error = "";
            if(publisherWebsite.Length == 0)
            {
                Error += "The publisher website field cannot be empty";
            }
            if(publisherWebsite.Length > 255)
            {
                Error += "The publisher website field cannot be longer than 255 characters";
            }
            return Error;
        }
        public string PublisherDateFoundedValid(string publisherDob)
        {
            String Error = "";
            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(publisherDob);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future ";
                }
                if (DateTemp > DateTime.Now.Date.AddHours(-23).AddMinutes(59) && DateTemp < DateTime.Now.Date)
                {
                    Error += "The date cannot be before today";
                }
                if (DateTemp < new DateTime(1753, 01, 01))
                {
                    // SQL wouldn't allow a date earlier than this, or after 31/12/9999
                    Error += "The publisher cannot be founded before 01/01/1753";
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