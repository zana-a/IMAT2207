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
                lblErrorOkay.Text = "There were issues with data entered" + Error;
            }

        }
        void Update()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            String Error = AllAuthors.ThisAuthor.AuthorNameValid(txtAEDAuthorName.Text) + ". " +
                            AllAuthors.ThisAuthor.AuthorDobValid(txtAEDAuthorDob.Text) + "." +
                                AllAuthors.ThisAuthor.AuthorDescValid(txtAEDAuthorDesc.Text);
            if(Error == "")
            {
                AllAuthors.ThisAuthor.Find(AuthorId);
                AllAuthors.ThisAuthor.Name = txtAEDAuthorName.Text;
                AllAuthors.ThisAuthor.DOB = Convert.ToDateTime(txtAEDAuthorDob.Text);
                AllAuthors.ThisAuthor.IsAlive = Convert.ToBoolean(cbxAEDAuthorIsAlive.Checked);
                AllAuthors.Update();
                Response.Redirect("AuthorAddEditDelete.aspx");
            }
            else
            {
                lblErrorOkay.Text = "There were problems with the data entered " + Error;
            }
        }
        void DisplayAuthors()
        {
            ClsAuthorCollection AllAuthors = new ClsAuthorCollection();
            AllAuthors.ThisAuthor.Find(AuthorId);
            txtAEDAuthorName.Text = AllAuthors.ThisAuthor.Name;
            txtAEDAuthorDob.Text = Convert.ToString(AllAuthors.ThisAuthor.DOB);
            cbxAEDAuthorIsAlive.Checked = AllAuthors.ThisAuthor.IsAlive;
        }
        protected void btnOkayAdd_Click(object sender, EventArgs e)
        {
            if(AuthorId == -1)
            {
                Add();
            }
            else
            {
                Update();
            }
            
        }
        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorAddEditDelete.aspx");
        }
    }
}