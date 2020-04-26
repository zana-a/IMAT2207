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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["UserId"] = -1;
            Response.Redirect("CustomerUser.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 UserId;

            if (lstCustomerUserList.SelectedIndex != -1)
            {
                UserId = Convert.ToInt32(lstCustomerUserList.SelectedValue);
                Session["UserId"] = UserId;
                Response.Redirect("CustomerUserDelete.aspx");
            }
            else
            {
                lblError.Text = "Please Select A Record To Delete From The List";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 UserId;

            if (lstCustomerUserList.SelectedIndex != -1)
            {
                UserId = Convert.ToInt32(lstCustomerUserList.SelectedValue);
                Session["UserId"] = UserId;
                Response.Redirect("CustomerUser.aspx");
            }
            else
            {
                lblError.Text = "Please Select A Record To Edit From The List";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            clsCustomerUserCollection customerUsers = new clsCustomerUserCollection();
            customerUsers.ReportByFullname(txtFilter.Text);

            lstCustomerUserList.DataSource = customerUsers.CustomerUserList;

            lstCustomerUserList.DataValueField = "UserId";
            lstCustomerUserList.DataTextField = "Fullname";
            lstCustomerUserList.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clsCustomerUserCollection customerUsers = new clsCustomerUserCollection();
            customerUsers.ReportByFullname("");

            lstCustomerUserList.DataSource = customerUsers.CustomerUserList;

            lstCustomerUserList.DataValueField = "UserId";
            lstCustomerUserList.DataTextField = "Fullname";
            lstCustomerUserList.DataBind();
        }
    }
}