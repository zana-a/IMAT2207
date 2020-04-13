<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="CustomerUserList.aspx.cs" Inherits="FolioFront.CustomerUser.CustomerUserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <h1>All Customers</h1>
        <form id="formCustomerUserList" runat="server">
            <div >
                <asp:ListBox CssClass="form-select width-fit height-full" ID="lstCustomerUserList" runat="server"></asp:ListBox>
            </div>
        </form>
    </div>
</asp:Content>






