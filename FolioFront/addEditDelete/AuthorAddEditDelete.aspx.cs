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
                AuthorCollection.ThisAuthor.AuthorId = Convert.ToInt32(txtAEDAuthorId.Text);
                AuthorCollection.ThisAuthor.Name = txtAEDAuthorName.Text;
                AuthorCollection.ThisAuthor.DOB = Convert.ToDateTime(txtAEDAuthorDob.Text);
                AuthorCollection.ThisAuthor.IsAlive = Convert.ToBoolean(cbxAEDAuthorIsAlive.Checked);
                AuthorCollection.Add();
                Response.Redirect("default.aspx");
            }
            else
            {
                lblErrorAED.Text = "There were issues with data entered";                
            }

        }
        protected void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("default.aspx");
        }
    }
}