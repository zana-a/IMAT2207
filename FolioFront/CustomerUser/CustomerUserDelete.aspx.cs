using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FolioClasses.UserManagement;

namespace FolioFront.CustomerUser
{
    public partial class CustomerUserDelete : System.Web.UI.Page
    {
        private Int32 UserId;

        protected void Page_Load(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(Session["UserId"]);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();
            allCustomers.thisCustomerUser.Find(UserId);
            allCustomers.Delete();
            Response.Redirect("CustomerUserList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerUserList.aspx");
        }
    }
}