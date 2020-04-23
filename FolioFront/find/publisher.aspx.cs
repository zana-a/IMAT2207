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
            txtFindPubName.Enabled = false;
            txtFindPubDateFounded.Enabled = false;
            cbxFindPubIsActive.Enabled = false;
            txtFindPubWebsite.Enabled = false;
        }
        protected void btnFindPublisher_Click(object sender, EventArgs e)
        {
            ClsPublisher aPublisher = new ClsPublisher();
            Int32 PublisherId;
            Boolean found = false;
            string PublisherIdCheck = txtFindPublisherId.Text;
            String Error = "";
            Error += aPublisher.PublisherIdValid(PublisherIdCheck);
            lblErrorFindPubId.Text = Error;
            if (Error == "")
            {
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
                    txtFindPubWebsite.Text = aPublisher.Website;
                }
            }
        }
    }
}