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
        private Int32 UserId;

        protected void Page_Load(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(Session["UserId"]);
            if (IsPostBack == false)
            {
                if (UserId != -1)
                {
                    DisplayAddress();
                }
            }
        }

        private void DisplayAddress()
        {
            clsCustomerUserCollection allCustomers = new clsCustomerUserCollection();

            allCustomers.thisCustomerUser.Find(UserId);

            txtUserId.Text = allCustomers.thisCustomerUser.UserId.ToString();
            txtFullName.Text = allCustomers.thisCustomerUser.Fullname;
            txtPassword.Text = allCustomers.thisCustomerUser.Password;
            txtDob.Text = allCustomers.thisCustomerUser.Dob.ToString();
            txtEmail.Text = allCustomers.thisCustomerUser.Email;
            txtTelephone.Text = allCustomers.thisCustomerUser.Telephone;
            txtNumOfBooksBought.Text = allCustomers.thisCustomerUser.NumOfBooksBought.ToString();
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

                if (aCustomerUser.IsEmailVerified == true)
                {
                    txtUserIsEmailVerified.Checked = true;
                } else
                {
                    txtUserIsEmailVerified.Checked = false;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            clsCustomerUser aCustomerUser = new clsCustomerUser();
            String error = "";

            String userId = txtUserId.Text;
            String fullname = txtFullName.Text;
            String password = txtPassword.Text;
            String dob = txtDob.Text;
            String email = txtEmail.Text;
            String telephone = txtTelephone.Text;
            String numOfBooksBought = txtNumOfBooksBought.Text;

            error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            if (error == "")
            {
                aCustomerUser.UserId = Convert.ToInt32(userId);
                aCustomerUser.Fullname = fullname;
                aCustomerUser.Password = password;
                aCustomerUser.Dob = Convert.ToDateTime(dob);
                aCustomerUser.Email = email;
                aCustomerUser.Telephone = telephone;

                if (txtUserIsEmailVerified.Checked == true)
                {
                    aCustomerUser.IsEmailVerified = true;
                }
                else
                {
                    aCustomerUser.IsEmailVerified = false;
                }

                clsCustomerUserCollection customerUserList = new clsCustomerUserCollection();
                
                if (UserId == -1)
                {
                    customerUserList.thisCustomerUser = aCustomerUser;
                    customerUserList.Add();
                } else
                {
                    customerUserList.thisCustomerUser.Find(UserId);
                    customerUserList.thisCustomerUser = aCustomerUser;
                    customerUserList.Update();
                }

                Response.Redirect("CustomerUserList.aspx");
            }
            else
            {
                lblError.Text = error;
            }
        }
    }
}