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
                    txtAuthorIsAlive.Checked = true;
                }
                else
                {
                    txtAuthorIsAlive.Checked = false;
                }
            }
        }
    }
}