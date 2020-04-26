using FolioClasses.AuthorManagement;
using System;
using System.Collections.Generic;

namespace FolioClasses
{
    public class ClsAuthorCollection
    {
        List<ClsAuthor> mAuthorList = new List<ClsAuthor>();
        ClsAuthor mThisAuthor = new ClsAuthor();
        public List<ClsAuthor> AuthorList
        {
            get
            {
                return mAuthorList;
            }
            set
            {
                mAuthorList = value;
            }
        }
        public int Count
        {
            get
            {
                return mAuthorList.Count;
            }
            set
            {

            }
        }
        public ClsAuthor ThisAuthor
        {
            get
            {
                return mThisAuthor;
            }
            set
            {
                mThisAuthor = value;
            }
        }
        public ClsAuthorCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAuthorManage_SelectAll");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mAuthorList = new List<ClsAuthor>();
            while (Index < RecordCount)
            {
                ClsAuthor AnAuthor = new ClsAuthor();
                AnAuthor.AuthorId = Convert.ToInt32(DB.DataTable.Rows[Index]["author_id"]);
                AnAuthor.Name = Convert.ToString(DB.DataTable.Rows[Index]["author_name"]);
                AnAuthor.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["author_dob"]);
                AnAuthor.Description = Convert.ToString(DB.DataTable.Rows[Index]["author_desc"]);
                AnAuthor.IsAlive = Convert.ToBoolean(DB.DataTable.Rows[Index]["author_isalive"]);
                AnAuthor.ImagePath = Convert.ToString(DB.DataTable.Rows[Index]["author_image"]);
                mAuthorList.Add(AnAuthor);
                Index++;
            }           
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
           // DB.AddParameter("@AuthorId", mThisAuthor.AuthorId);
            DB.AddParameter("@Name", mThisAuthor.Name);
            DB.AddParameter("@Dob", mThisAuthor.DOB);
            DB.AddParameter("@Description", mThisAuthor.Description);
            DB.AddParameter("@IsAlive", mThisAuthor.IsAlive);
            DB.AddParameter("@Image", mThisAuthor.ImagePath);
            return DB.Execute("sproc_tblAuthorManage_Insert");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AuthorId", mThisAuthor.AuthorId);
            DB.Execute("sproc_tblAuthorManage_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AuthorId", mThisAuthor.AuthorId);
            DB.AddParameter("@Name", mThisAuthor.Name);
            DB.AddParameter("@Dob", mThisAuthor.DOB);
            DB.AddParameter("@Description", mThisAuthor.Description);
            DB.AddParameter("@IsAlive", mThisAuthor.IsAlive);
            DB.AddParameter("@Image", mThisAuthor.ImagePath);
            DB.Execute("sproc_tblAuthorManage_Update");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblAuthorManage_FilterByName");
            PopulateArray(DB);
        }
    }
}