using FolioClasses.PublisherManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront.addEditDelete
{
    public partial class PublisherAddEditDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                DisplayPublishers();
            }
        }
        void DisplayPublishers()
        {
            ClsPublisherCollection Publishers = new ClsPublisherCollection();
            lstPublishers.DataSource = Publishers.PublisherList;
            lstPublishers.DataValueField = "PublisherId";
            lstPublishers.DataTextField = "Name";
            lstPublishers.DataBind();
        }
        protected void btnAddPublisher_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPublisher.aspx");
        }
        protected void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            Int32 PublisherId;
            if(lstPublishers.SelectedIndex != -1)
            {
                PublisherId = Convert.ToInt32(lstPublishers.SelectedValue);
                Session["PublisherId"] = PublisherId;
                Response.Redirect("PublisherDeleteConfirm.aspx");
            }
            else
            {
                lblErrorPubAED.Text = "Please select a record to delete from the list";
            }
        }
        protected void btnEditPublisher_Click(object sender, EventArgs e)
        {

        }
    }
}