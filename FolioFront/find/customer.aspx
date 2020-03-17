<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="FolioFront.ACustomerUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <form id="formCustomerUserFind" runat="server">
        <div class="form-group border clearfix rounded-2 p-4">
            <div class="p-2 mb-2">
                <h1>Find Customer</h1>
            </div>
            <div class="col-6 float-left p-2">
                <label for="txtUserId">
                    Customer ID:
                    <asp:TextBox CssClass="form-control width-full" ID="txtUserId" runat="server" />
                </label>
            </div>
            <div class="col-6 float-left p-2">
                <label for="txtFullName">
                    Name:
                    <asp:TextBox CssClass="form-control width-full" ID="txtFullName" runat="server" />
                </label>
            </div>
            <div class="col-6 float-left p-2">
                <label for="txtPassword">
                    Password:
                    <asp:TextBox CssClass="form-control width-full" ID="txtPassword" runat="server" />
                </label>
            </div>
            <div class="col-6 float-left p-2">
                <label for="txtDob">
                    Date of Birth:
                    <asp:TextBox CssClass="form-control width-full" ID="txtDob" runat="server" />
                </label>
            </div>
            <div class="col-6 float-left p-2">
                <label for="txtTelephone">
                    Telephone:
                    <asp:TextBox CssClass="form-control width-full" ID="txtTelephone" runat="server" />
                </label>
            </div>
            <div class="col-6 float-left p-2">
                <label for="txtTelephone">
                    Email:
                    <asp:TextBox CssClass="form-control width-full" ID="txtEmail" runat="server"/>
                </label>
            </div>
            <div class="col-12 float-left p-2">
                <label for="txtNumOfBooksBought">
                    Number of Books Bought:
                    <asp:TextBox CssClass="form-control width-full" ID="txtNumOfBooksBought" runat="server"/>
                </label>
            </div>
            <div class="col-12 float-left p-2">
                <div class="form-checkbox">
                    <label for="txtUserIsEmailVerified">
                        Email Verified 
                        <asp:CheckBox ID="txtUserIsEmailVerified" runat="server" />
                    </label>
                </div>
            </div>
            <div class="col-12 float-left pr-2">
                <div class="clearfix">
                    <asp:Button CssClass="btn btn-primary width-full" ID="btnFindCustomer" runat="server" Text="Find" OnClick="btnFindCustomer_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>




