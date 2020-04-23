using FolioClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront.addEditDelete
{
    public partial class Delete : System.Web.UI.Page
    {
        Int32 AuthorId;
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthorId = Convert.ToInt32(Session["AuthorId"]);
        }
        void DeleteAuthor()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            AllAuthors.ThisAuthor.Find(AuthorId);
            AllAuthors.Delete();
        }
        protected void btnDeleteYes_Click(object sender, EventArgs e)
        {
            DeleteAuthor();
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
        protected void btnDeleteNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorAddEditDelete.aspx");
        }

    }
}