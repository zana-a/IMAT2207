using FolioClasses.PublisherManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront.addEditDelete
{
    public partial class AddPublisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOkayAdd_Click(object sender, EventArgs e)
        {
            ClsPublisher aPublisher = new ClsPublisher();
            string PublisherName = txtAEDPublisherName.Text;
            string PublisherDateFounded = txtAEDPublisherDateFounded.Text;
            string PublisherWebsite = txtAEDPublisherWebsite.Text;
            string Error = "";
            Error += aPublisher.PublisherNameValid(PublisherName);
            Error += aPublisher.PublisherDateFoundedValid(PublisherDateFounded);
            Error += aPublisher.PublisherWebsiteValid(PublisherWebsite);
            if(Error == "")
            {
                aPublisher.Name = PublisherName;
                aPublisher.DateFounded = Convert.ToDateTime(PublisherDateFounded);
                aPublisher.IsActive = cbxAEDPublisherIsActive.Checked;
                aPublisher.Website = PublisherWebsite;

                ClsPublisherCollection PublisherList = new ClsPublisherCollection();
                PublisherList.ThisPublisher = aPublisher;
                PublisherList.Add();
                Response.Redirect("PublisherAddEditDelete.aspx");
            }
            else
            {
                lblErrorOkay.Text = Error;
            }
        }
        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("PublisherAddEditDelete.aspx");
        }
    }
}