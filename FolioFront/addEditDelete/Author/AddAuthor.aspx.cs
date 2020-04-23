using FolioClasses;
using FolioClasses.AuthorManagement;
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
        Int32 AuthorId;
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthorId = Convert.ToInt32(Session["AuthorId"]);
            if(IsPostBack == false)
            {
                if(AuthorId != -1)
                {
                    DisplayAuthors();
                }
            }
        }        void DisplayAuthors()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            AllAuthors.ThisAuthor.Find(AuthorId);
            txtAEDAuthorName.Text = AllAuthors.ThisAuthor.Name;
            txtAEDAuthorDob.Text = Convert.ToString(AllAuthors.ThisAuthor.DOB);
            cbxAEDAuthorIsAlive.Checked = AllAuthors.ThisAuthor.IsAlive;
        }
        protected void btnOkayAdd_Click(object sender, EventArgs e)
        {
            ClsAuthor AnAuthor = new ClsAuthor();
            string AuthorName = txtAEDAuthorName.Text;
            string AuthorDob = txtAEDAuthorDob.Text;
            string Error = "";
            Error += AnAuthor.AuthorNameValid(AuthorName);
            Error += AnAuthor.AuthorDobValid(AuthorDob);
            if(Error == "")
            {
                AnAuthor.AuthorId = AuthorId;
                AnAuthor.Name = AuthorName;
                AnAuthor.DOB = Convert.ToDateTime(AuthorDob);
                AnAuthor.IsAlive = cbxAEDAuthorIsAlive.Checked;

                ClsAuthorCollection AuthorList = new ClsAuthorCollection();
                if (AuthorId == -1)
                {
                    AuthorList.ThisAuthor = AnAuthor;
                    AuthorList.Add();
                }
                else
                {
                    AuthorList.ThisAuthor.Find(AuthorId);
                    AuthorList.ThisAuthor = AnAuthor;
                    AuthorList.Update();
                }
                Response.Redirect("AuthorAddEditDelete.aspx");
            }
            else
            {
                lblErrorOkay.Text = Error;
            }
        }
        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
    }
}