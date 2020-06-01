using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolioClasses.BookManage;

namespace FolioClasses.BookManage
{
    public class clsBookCollection
    {
        List<clsBookDatabase> mBookList = new List<clsBookDatabase>();
        clsBookDatabase mthisBook = new clsBookDatabase();
        public clsBookDatabase thisBook
        {
            get
            {
                return mthisBook;
            }
            set
            {
                mthisBook = value;
            }
        }
        public List<clsBookDatabase> BookList
        {
            get
            {
                return mBookList;
            }
            set
            {
                mBookList = value;
            }
        }
        public int Count
        {
            get
            {
                return mBookList.Count;
            }
            set
            {

            }
        }
        public clsBookCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection db = new clsDataConnection();
            db.Execute("sproc_tblBookManage_SelectAll");
            RecordCount = db.Count;
            while(Index < RecordCount)
            {
                clsBookDatabase ABook = new clsBookDatabase();
                ABook.BID = Convert.ToInt32(db.DataTable.Rows[Index]["book_id"]);
                ABook.AID = Convert.ToInt32(db.DataTable.Rows[Index]["author_id"]);
                ABook.BT = Convert.ToString(db.DataTable.Rows[Index]["bookt_title"]);
                ABook.BP = Convert.ToDouble(db.DataTable.Rows[Index]["book_price"]);
                ABook.BTy = Convert.ToString(db.DataTable.Rows[Index]["book_type"]);
                ABook.BG = Convert.ToString(db.DataTable.Rows[Index]["book_genre"]);
                ABook.BPD = Convert.ToDateTime(db.DataTable.Rows[Index]["book_pubdate"]);
                ABook.FE = Convert.ToBoolean(db.DataTable.Rows[Index]["book_first_ed"]);
                mBookList.Add(ABook);
                Index++;
            }
        }
        public int Add()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@AID", mthisBook.AID);
            db.AddParameter("@BT", mthisBook.BT);
            db.AddParameter("@BP", mthisBook.BP);
            db.AddParameter("@BTy", mthisBook.BTy);
            db.AddParameter("@BG", mthisBook.BG);
            db.AddParameter("@BPD", mthisBook.BPD);
            db.AddParameter("@FE", mthisBook.FE);

            return db.Execute("sproc_tblBookManage_Insert");

        }
        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@BID", mthisBook.BID);
            db.Execute("sproc_tblBookManage_Delete");
        }
        public void Update()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@BID", mthisBook.BID);
            db.AddParameter("@AID", mthisBook.AID);
            db.AddParameter("@BT", mthisBook.BT);
            db.AddParameter("@BP", mthisBook.BP);
            db.AddParameter("@BTy", mthisBook.BTy);
            db.AddParameter("@BG", mthisBook.BG);
            db.AddParameter("@BPD", mthisBook.BPD);
            db.AddParameter("@FE", mthisBook.FE);

            db.Execute("sproc_tblBookManage_Update");
        }
    }
}
