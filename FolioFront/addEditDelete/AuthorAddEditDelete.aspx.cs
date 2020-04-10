using FolioClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront
{
    public partial class AuthorCollection : System.Web.UI.Page
    {
        Int32 AuthorId;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Add()
        {
            ClsAuthorCollection AuthorCollection = new ClsAuthorCollection();
            string authorName = txtAEDAuthorName.Text;
            string authorDob = txtAEDAuthorDob.Text;
            String Error = AuthorCollection.ThisAuthor.AuthorNameValid(authorName) + ". " +
                           AuthorCollection.ThisAuthor.AuthorDobValid(authorDob);
            if(Error == "")
            { 
                AuthorCollection.ThisAuthor.Name = txtAEDAuthorName.Text;
                AuthorCollection.ThisAuthor.DOB = Convert.ToDateTime(authorDob);
                AuthorCollection.ThisAuthor.IsAlive = Convert.ToBoolean(cbxAEDAuthorIsAlive.Checked);
                AuthorCollection.Add();
                Response.Redirect("AuthorAddEditDelete.aspx");
            }
            else
            {
                lblErrorAED.Text = "There were issues with data entered";                
            }

        }
        void DeleteAuthor()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            AllAuthors.ThisAuthor.Find(AuthorId);
            AllAuthors.Delete();
        }
        protected void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
        protected void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            Int32 AuthorId;
            if(lstAuthors.SelectedIndex != -1)
            {
                AuthorId = Convert.ToInt32(lstAuthors.SelectedValue);
                Session["AuthorId"] = AuthorId;
                Response.Redirect("AuthorDeleteConfirm.aspx");
            }
            else
            {
                lblErrorAED.Text = "Please select a record to delete from the list";
            }
        }
        protected void btnDeleteYes_Click(object sender, EventArgs e)
        {
            DeleteAuthor();
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
    }
}