using System;
using FolioClasses.AuthorManagement;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront
{
    public partial class Author : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOkAuthor_Click(object sender, EventArgs e)
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            string authorId = txtAuthorId.Text;
            string authorName = txtAuthorName.Text;
            string authorDob = txtAuthorDob.Text;
            string authorIsAlive = cbxAuthorIsAlive.Text;
            String Error = "";
            lblErrorName.Text = Error;
            lblErrorDob.Text = Error;
            Error = AnAuthor.AuthorNameValid(authorName);
            if(Error == "")
            {
                AnAuthor.Name = txtAuthorName.Text;
                
            }
            else
            {
                lblErrorName.Text = Error;
            }
            Error = AnAuthor.AuthorDobValid(authorDob);
            if (Error == "")
            {
                AnAuthor.DOB = Convert.ToDateTime(txtAuthorDob.Text);
            }
            else
            {
                lblErrorDob.Text = Error;
            }
            //AnAuthor.AuthorId = Convert.ToInt32(txtAuthorId.Text);
            //AnAuthor.IsAlive = Convert.ToBoolean(cbxAuthorIsAlive);
            Session["AnAuthor"] = AnAuthor;
            // Response.Write("AuthorViewer.aspx");

        }
        protected void btnFindAuthor_Click(object sender, EventArgs e)
        {
            ClsAuthor anAuthor = new ClsAuthor();
            Int32 authorId;
            Boolean found = false;
            authorId = Convert.ToInt32(txtAuthorId.Text);
            found = anAuthor.Find(authorId);

            if (found == true)
            {
                txtAuthorId.Text = anAuthor.AuthorId.ToString();
                txtAuthorName.Text = anAuthor.Name;
                txtAuthorDob.Text = anAuthor.DOB.ToString();
                if (anAuthor.IsAlive == true)
                {
                    cbxAuthorIsAlive.Checked = true;
                }
                else
                {
                    cbxAuthorIsAlive.Checked = false;
                }
            }
        }

    }
}