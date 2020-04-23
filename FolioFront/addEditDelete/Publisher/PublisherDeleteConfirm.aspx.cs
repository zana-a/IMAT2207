using FolioClasses.PublisherManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront.addEditDelete
{
    public partial class PublisherDeleteConfirm : System.Web.UI.Page
    {
        Int32 PublisherId;
        protected void Page_Load(object sender, EventArgs e)
        {
            PublisherId = Convert.ToInt32(Session["PublisherId"]);
        }
        protected void btnDeleteYes_Click(object sender, EventArgs e)
        {
            ClsPublisherCollection Publishers = new ClsPublisherCollection();
            Publishers.ThisPublisher.Find(PublisherId);
            Publishers.Delete();
            Response.Redirect("PublisherAddEditDelete.aspx");
        }
        protected void btnDeleteNo_Click(Object sender, EventArgs e)
        {
            Response.Redirect("PublisherAddEditDelete.aspx");
        }
    }
}