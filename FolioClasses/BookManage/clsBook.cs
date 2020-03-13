using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolioClasses.BookManage
{
    public class clsBook
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
            mBookID = 2;
            mAuthorID = 1;
            mBookTitle = "Blade Runner";
            mBookPrice = 12.34;
            mBookType = "Novel";
            mBookGenre = "Sci-Fi";
            mBookPubDate = Convert.ToDateTime("01/01/1980");
            mFirstEdition = true;
            //always return true
            return true;
        }
    }
}