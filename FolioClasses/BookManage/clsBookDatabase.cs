using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolioClasses.BookManage
{
    public class clsBookDatabase
    {
        private Int32 mBookID;
        public Int32 BID
        {
            get
            {
                return mBookID;
            }
            set
            {
                mBookID = value;
            }
        }
        private Int32 mAuthorID;
        public Int32 AID
        {
            get
            {
                return mAuthorID;
            }
            set
            {
                mAuthorID = value;
            }
        }
        private String mBookTitle;
        public String BT
        {
            get
            {
                return mBookTitle;
            }
            set
            {
                mBookTitle = value;
            }
        }
        private double mBookPrice;
        public double BP
        {
            get
            {
                return mBookPrice;
            }
            set
            {
                mBookPrice = value;
            }
        }
        private String mBookType;
        public String BTy
        {
            get
            {
                return mBookType;
            }
            set
            {
                mBookType = value;
            }
        }
        private String mBookGenre;
        public String BG
        {
            get
            {
                return mBookGenre;
            }
            set
            {
                mBookGenre = value;
            }
        }
        private DateTime mBookPubDate;
        public DateTime BPD
        {
            get
            {
                return mBookPubDate;
            }
            set
            {
                mBookPubDate = value;
            }
        }
        private bool mFirstEdition;
        public bool FE
        {
            get
            {
                return mFirstEdition;
            }
            set
            {
                mFirstEdition = value;
            }
        }
        public bool Find(int BookID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookID", BookID);
            DB.Execute("sproc_tblBookManage_FilterByBookId");
            if (DB.Count == 1)
            {
                mBookID = Convert.ToInt32(DB.DataTable.Rows[0]["book_id"]);
                mAuthorID = Convert.ToInt32(DB.DataTable.Rows[0]["author_id"]);
                mBookTitle = Convert.ToString(DB.DataTable.Rows[0]["bookt_title"]);
                mBookPrice = Convert.ToDouble(DB.DataTable.Rows[0]["book_price"]);
                mBookType = Convert.ToString(DB.DataTable.Rows[0]["book_type"]);
                mBookGenre = Convert.ToString(DB.DataTable.Rows[0]["book_genre"]);
                mBookPubDate = Convert.ToDateTime(DB.DataTable.Rows[0]["book_pubdate"]);
                mFirstEdition = Convert.ToBoolean(DB.DataTable.Rows[0]["book_first_ed"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
