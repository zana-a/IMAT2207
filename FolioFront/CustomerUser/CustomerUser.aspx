<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="CustomerUser.aspx.cs" Inherits="FolioFront.ACustomerUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formCustomerUserFind" runat="server">
            <div class="form-group border clearfix rounded-2 p-4 bg-white">
                <div class="p-2 mb-2">
                    <h1>Find Customer</h1>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtUserId">
                        Customer ID:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtUserId" runat="server"/>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFullName">
                        Name:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFullName" runat="server" />
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtPassword">
                        Password:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtPassword" runat="server" />
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtDob">
                        Date of Birth:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtDob" runat="server" />
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtTelephone">
                        Telephone:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtTelephone" runat="server" />
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtTelephone">
                        Email:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtEmail" runat="server" />
                </div>
                <div class="col-12 float-left p-2">
                    <label for="txtNumOfBooksBought">
                        Number of Books Bought:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtNumOfBooksBought" runat="server" />
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
                        <asp:Button CssClass="btn btn-primary" ID="btnFind" runat="server" Text="Find" OnClick="btnFindCustomer_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
                    </div>
                </div>
                <div class="col-12 float-left pr-2">
                    <div class="clearfix">
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>




