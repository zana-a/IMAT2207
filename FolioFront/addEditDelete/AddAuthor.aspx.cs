using FolioClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront.addEditDelete
{
    public partial class AddAuthor : System.Web.UI.Page
    {
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
            if (Error == "")
            {
                AuthorCollection.ThisAuthor.Name = txtAEDAuthorName.Text;
                AuthorCollection.ThisAuthor.DOB = Convert.ToDateTime(authorDob);
                AuthorCollection.ThisAuthor.IsAlive = Convert.ToBoolean(cbxAEDAuthorIsAlive.Checked);
                AuthorCollection.Add();
                Response.Redirect("AuthorAddEditDelete.aspx");
            }
            else
            {
                lblErrorOkay.Text = "There were issues with data entered";
            }

        }
        protected void btnOkayAdd_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
    }
}