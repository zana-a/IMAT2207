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
            string authorId = txtFindAuthorId.Text;
            string authorName = txtFindAuthorName.Text;
            string authorDob = txtFindAuthorDob.Text;
            string authorIsAlive = cbxFindAuthorIsAlive.Text;
            String Error = "";
            lblErrorFindName.Text = Error;
            lblErrorFindDob.Text = Error;
            Error = AnAuthor.AuthorNameValid(authorName);
            if(Error == "")
            {
                AnAuthor.Name = txtFindAuthorName.Text;
                
            }
            else
            {
                lblErrorFindName.Text = Error;
            }
            Error = AnAuthor.AuthorDobValid(authorDob);
            if (Error == "")
            {
                AnAuthor.DOB = Convert.ToDateTime(txtFindAuthorDob.Text);
            }
            else
            {
                lblErrorFindDob.Text = Error;
            }
            //AnAuthor.AuthorId = Convert.ToInt32(txtFindAuthorId.Text);
            //AnAuthor.IsAlive = Convert.ToBoolean(cbxAuthorIsAlive);
            Session["AnAuthor"] = AnAuthor;
            // Response.Write("AuthorViewer.aspx");

        }
        protected void btnFindAuthor_Click(object sender, EventArgs e)
        {
            ClsAuthor anAuthor = new ClsAuthor();
            Int32 authorId;
            Boolean found = false;
            authorId = Convert.ToInt32(txtFindAuthorId.Text);
            found = anAuthor.Find(authorId);

            if (found == true)
            {
                txtFindAuthorId.Text = anAuthor.AuthorId.ToString();
                txtFindAuthorName.Text = anAuthor.Name;
                txtFindAuthorDob.Text = anAuthor.DOB.ToString();
                if (anAuthor.IsAlive == true)
                {
                    cbxFindAuthorIsAlive.Checked = true;
                }
                else
                {
                    cbxFindAuthorIsAlive.Checked = false;
                }
            }
        }

    }
}