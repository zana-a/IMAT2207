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
        Int32 PublisherId;
        protected void Page_Load(object sender, EventArgs e)
        {
            PublisherId = Convert.ToInt32(Session["PublisherId"]);
            if(IsPostBack == false)
            {
                if(PublisherId != -1)
                {
                    DisplayPublisher();
                }
            }
        }
        void DisplayPublisher()
        {
            ClsPublisherCollection Publishers = new ClsPublisherCollection();
            Publishers.ThisPublisher.Find(PublisherId);
            txtAEDPublisherName.Text = Publishers.ThisPublisher.Name;
            txtAEDPublisherDateFounded.Text = Publishers.ThisPublisher.DateFounded.ToString();
            cbxAEDPublisherIsActive.Checked = Publishers.ThisPublisher.IsActive;
            txtAEDPublisherWebsite.Text = Publishers.ThisPublisher.Website;
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
                aPublisher.PublisherId = PublisherId;
                aPublisher.Name = PublisherName;
                aPublisher.DateFounded = Convert.ToDateTime(PublisherDateFounded);
                aPublisher.IsActive = cbxAEDPublisherIsActive.Checked;
                aPublisher.Website = PublisherWebsite;

                ClsPublisherCollection PublisherList = new ClsPublisherCollection();
                if(PublisherId == -1)
                {
                    PublisherList.ThisPublisher = aPublisher;
                    PublisherList.Add();
                }
                else
                {
                    PublisherList.ThisPublisher.Find(PublisherId);
                    PublisherList.ThisPublisher = aPublisher;
                    PublisherList.Update();
                }                
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