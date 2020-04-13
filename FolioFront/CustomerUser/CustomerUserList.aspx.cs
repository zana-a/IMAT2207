using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FolioClasses.UserManagement;

namespace FolioFront.CustomerUser
{
    public partial class CustomerUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayCustomerUsers();
            }
        }

        void DisplayCustomerUsers()
        {
            clsCustomerUserCollection customerUsers = new clsCustomerUserCollection();
            lstCustomerUserList.DataSource = customerUsers.CustomerUserList;
            lstCustomerUserList.DataValueField = "UserId";
            lstCustomerUserList.DataTextField = "Fullname";
            lstCustomerUserList.DataBind();
        }
    }
}