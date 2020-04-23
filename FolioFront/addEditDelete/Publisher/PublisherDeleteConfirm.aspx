<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="PublisherDeleteConfirm.aspx.cs" Inherits="FolioFront.addEditDelete.PublisherDeleteConfirm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formPublisherDelete" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <div class="p-2 mb-2">
                    <h1>Are you sure you want to delete this entry?</h1>
                </div>
                <div class="col-6 float-left p-2">
                    <asp:Button CssClass="btn btn-primary" ID="btnDeleteYes" runat="server" Text="Yes" OnClick="btnDeleteYes_Click" />
                    <asp:Button CssClass="btn btn-primary" ID="btnDeleteNo" runat="server" Text="No" OnClick="btnDeleteNo_Click" />
                </div>
            </div>
        </form>
    </div>
</asp:Content>