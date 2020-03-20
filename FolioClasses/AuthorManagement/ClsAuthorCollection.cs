using FolioClasses.AuthorManagement;
using System;
using System.Collections.Generic;

namespace FolioClasses
{
    public class ClsAuthorCollection
    {
        List<ClsAuthor> mAuthorList = new List<ClsAuthor>();
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
        public ClsAuthor ThisAuthor { get; set; }
        public ClsAuthorCollection()
        {
            ClsAuthor TestAuthor = new ClsAuthor();
            TestAuthor.AuthorId = 1;
            TestAuthor.Name = "Some Author";
            TestAuthor.IsAlive = true;
            mAuthorList.Add(TestAuthor);
            TestAuthor = new ClsAuthor();
            TestAuthor.AuthorId = 2;
            TestAuthor.Name = "Author Some";
            TestAuthor.IsAlive = false;
            mAuthorList.Add(TestAuthor);
        }
    }
}