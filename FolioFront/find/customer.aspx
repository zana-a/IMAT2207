<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="FolioFront.ACustomerUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <h1>Find Customer</h1>
    <form id="formCustomerUserFind" runat="server">
        <div>
            <div>
                <asp:Label ID="lblUserId" runat="server" Text="Id:"></asp:Label>
            </div>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblFullName" runat="server" Text="Full Name:"></asp:Label>
            </div>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            </div>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblDob" runat="server" Text="Date of Birth:"></asp:Label>
            </div>
            <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            </div>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblTelephone" runat="server" Text="Telephone:"></asp:Label>
            </div>
            <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblNumOfBooksBought" runat="server" Text="Number of Books Bought:"></asp:Label>
            </div>
            <asp:TextBox ID="txtNumOfBooksBought" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <div>
                <asp:Label ID="lblUserIsEmailVerified" runat="server" Text="Email Verified:"></asp:Label>
            </div>
            <asp:CheckBox ID="txtUserIsEmailVerified" runat="server" />
        </div>
        <div>
            <br />
            <asp:Button ID="btnFindCustomer" runat="server" Text="Find" OnClick="btnFindCustomer_Click" />
        </div>
    </form>
</asp:Content>



