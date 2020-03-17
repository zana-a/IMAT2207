using FolioClasses.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FolioFront
{
    public partial class ACustomerUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFindCustomer_Click(object sender, EventArgs e)
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            Int32 userId;
            Boolean found = false;
            userId = Convert.ToInt32(txtUserId.Text);
            found = aCustomerUser.Find(userId);

            if (found == true)
            {
                txtUserId.Text = aCustomerUser.UserId.ToString();
                txtFullName.Text = aCustomerUser.Fullname;
                txtPassword.Text = aCustomerUser.Password;
                txtDob.Text = aCustomerUser.Dob.ToString();
                txtEmail.Text = aCustomerUser.Email;
                txtTelephone.Text = aCustomerUser.Telephone;
                txtNumOfBooksBought.Text = aCustomerUser.NumOfBooksBought.ToString();
                txtUserIsEmailVerified.Text = aCustomerUser.IsEmailVerified.ToString();
            }
        }
    }
}