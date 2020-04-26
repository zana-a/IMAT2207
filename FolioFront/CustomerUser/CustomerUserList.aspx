<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="CustomerUserList.aspx.cs" Inherits="FolioFront.CustomerUser.CustomerUserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <div class="Subhead">
          <div class="Subhead-heading">Customers</div>
        </div>
        <form id="formCustomerUserList" runat="server">
            <div class="d-flex flex-items-baseline">
                <asp:Label ID="lblEnterAName" runat="server" Text="Enter a Name:" CssClass="pr-2"></asp:Label>
                <asp:TextBox cssClass="form-control mb-3" ID="txtFilter" runat="server"></asp:TextBox>
                <div>
                    <asp:button CssClass="btn mr-2 btn-default" runat="server" text="Apply" OnClick="btnApply_Click"/>
                    <asp:button CssClass="btn mr-2 btn-default" runat="server" text="Clear" OnClick="btnClear_Click"/>
                </div>
            </div>
            <div>
                <asp:ListBox CssClass="form-select width-fit height-full width-full pb-10" ID="lstCustomerUserList" runat="server"></asp:ListBox>
            </div>
            <div class="d-flex py-4 width-full flex-justify-end">
                <asp:button CssClass="btn mr-2 btn-primary" runat="server" text="Add" OnClick="btnAdd_Click"/>
                <asp:button CssClass="btn mr-2 btn-warning" runat="server" text="Edit" OnClick="btnEdit_Click" />
                <asp:button CssClass="btn mr-0 btn-danger" runat="server" text="Delete" OnClick="btnDelete_Click" />
            </div>
            <asp:label runat="server" text="" ID="lblError"></asp:label>
        </form>
    </div>
</asp:Content>

