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
            String Error = "";

            String userId = txtUserId.Text;
            String fullname = txtFullName.Text;
            String password = txtPassword.Text;
            String dob = txtDob.Text;
            String email = txtEmail.Text;
            String telephone = txtTelephone.Text;
            String numOfBooksBought = txtNumOfBooksBought.Text;

            Error = aCustomerUser.Valid(fullname, password, dob, email, telephone, numOfBooksBought);

            if (Error == "")
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

                Session["aCustomerUser"] = aCustomerUser;
                Response.Write("find/customer.aspx");
            }
            else
            {
                lblError.Text = Error;
            }
        }
    }
}