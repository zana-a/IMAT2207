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
            txtFindAuthorName.Enabled = false;
            txtFindAuthorDob.Enabled = false;
            txtFindAuthorDesc.Enabled = false;
            cbxFindAuthorIsAlive.Enabled = false;
        }
        protected void btnFindAuthor_Click(object sender, EventArgs e)
        {
            ClsAuthor anAuthor = new ClsAuthor();
            Int32 authorId;
            Boolean found = false;
            string AuthorIdCheck = txtFindAuthorId.Text;
            String Error = "";
            Error += anAuthor.AuthorIdValid(AuthorIdCheck);
            lblErrorFindFindId.Text = Error;
            if (Error == "")
            {
                authorId = Convert.ToInt32(txtFindAuthorId.Text);
                found = anAuthor.Find(authorId);
                
                if (found == true)
                {
                    txtFindAuthorName.Text = anAuthor.Name;
                    txtFindAuthorDob.Text = anAuthor.DOB.ToString();
                    txtFindAuthorDesc.Text = anAuthor.Description;
                    if (anAuthor.IsAlive == true)
                    {
                        cbxFindAuthorIsAlive.Checked = true;
                    }
                    else
                    {
                        cbxFindAuthorIsAlive.Checked = false;
                    }
                    imgFindAuthorImage.ImageUrl = anAuthor.ImagePath;
                }
            }
        }

    }
}