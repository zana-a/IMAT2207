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
            if (IsPostBack == false)
            {
                DisplayAuthors();
            }
        }
        void DisplayAuthors()
        {
            FolioClasses.ClsAuthorCollection Authors = new FolioClasses.ClsAuthorCollection();
            lstAuthors.DataSource = Authors.AuthorList;
            lstAuthors.DataValueField = "AuthorId";
            lstAuthors.DataTextField = "Name";
            lstAuthors.DataBind();
        }
        
        protected void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Session["AuthorId"] = -1;
            Response.Redirect("AddAuthor.aspx");
        }
        protected void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (lstAuthors.SelectedIndex != -1)
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
        
    }
}