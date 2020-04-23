using System;
using FolioClasses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolioClasses.PublisherManagement
{
    public class ClsPublisherCollection
    {
        List<ClsPublisher> mPublisherList = new List<ClsPublisher>();
        ClsPublisher mThisPublisher = new ClsPublisher();
        public List<ClsPublisher> PublisherList
        {
            get
            {
                return mPublisherList;
            }
            set
            {
                mPublisherList = value;
            }
        }
        public int Count
        {
            get
            {
                return mPublisherList.Count;
            }
            set
            {

            }
        }
        public ClsPublisher ThisPublisher
        {
            get
            {
                return mThisPublisher;
            }
            set
            {
                mThisPublisher = value;
            }
        }
        public ClsPublisherCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPublisherManage_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsPublisher aPublisher = new ClsPublisher();
                aPublisher.PublisherId = Convert.ToInt32(DB.DataTable.Rows[Index]["Publisher_id"]);
                aPublisher.Name = Convert.ToString(DB.DataTable.Rows[Index]["Publisher_name"]);
                aPublisher.DateFounded = Convert.ToDateTime(DB.DataTable.Rows[Index]["Publisher_datefounded"]);
                aPublisher.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["Publisher_isactive"]);
                aPublisher.Website = Convert.ToString(DB.DataTable.Rows[Index]["Publisher_website"]);
                mPublisherList.Add(aPublisher);
                Index++;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            // DB.AddParameter("@PublisherId", mThisPublisher.PublisherId);
            DB.AddParameter("@Name", mThisPublisher.Name);
            DB.AddParameter("@DateFounded", mThisPublisher.DateFounded);
            DB.AddParameter("@IsActive", mThisPublisher.IsActive);
            DB.AddParameter("@Website", mThisPublisher.Website);
            return DB.Execute("sproc_tblPublisherManage_Insert");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PublisherId", mThisPublisher.PublisherId);
            DB.Execute("sproc_tblPublisherManage_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PublisherId", mThisPublisher.PublisherId);
            DB.AddParameter("@Name", mThisPublisher.Name);
            DB.AddParameter("@DateFounded", mThisPublisher.DateFounded);
            DB.AddParameter("@IsActive", mThisPublisher.IsActive);
            DB.AddParameter("@Website", mThisPublisher.Website);
            DB.Execute("sproc_tblPublisherManage_Update");
        }
    }
}
