using FolioClasses.PublisherManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront.find
{
    public partial class publisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOkPublisher_Click(object sender, EventArgs e)
        {
            ClsPublisher aPublisher = new ClsPublisher();
            string PublisherId = txtFindPublisherId.Text;
            string PublisherName = txtFindPubName.Text;
            string PublisherDob = txtFindPubDateFounded.Text;
            string PublisherIsAlive = cbxFindPubIsActive.Text;
            String Error = "";
            lblErrorFindPubName.Text = Error;
            lblErrorFindPubDateFounded.Text = Error;
            Error = aPublisher.PublisherNameValid(PublisherName);
            if (Error == "")
            {
                aPublisher.Name = txtFindPubName.Text;

            }
            else
            {
                lblErrorFindPubName.Text = Error;
            }
            Error = aPublisher.PublisherDateFoundedValid(PublisherDob);
            if (Error == "")
            {
                aPublisher.DateFounded = Convert.ToDateTime(txtFindPubDateFounded.Text);
            }
            else
            {
                lblErrorFindPubDateFounded.Text = Error;
            }
            //aPublisher.PublisherId = Convert.ToInt32(txtFindPubId.Text);
            //aPublisher.IsAlive = Convert.ToBoolean(cbxPublisherIsAlive);
            Session["aPublisher"] = aPublisher;
            // Response.Write("PublisherViewer.aspx");

        }
        protected void btnFindPublisher_Click(object sender, EventArgs e)
        {
            ClsPublisher aPublisher = new ClsPublisher();
            Int32 PublisherId;
            Boolean found = false;
            PublisherId = Convert.ToInt32(txtFindPublisherId.Text);
            found = aPublisher.Find(PublisherId);

            if (found == true)
            {
                txtFindPublisherId.Text = aPublisher.PublisherId.ToString();
                txtFindPubName.Text = aPublisher.Name;
                txtFindPubDateFounded.Text = aPublisher.DateFounded.ToString();
                if (aPublisher.IsActive == true)
                {
                    cbxFindPubIsActive.Checked = true;
                }
                else
                {
                    cbxFindPubIsActive.Checked = false;
                }
            }
        }
    }
}