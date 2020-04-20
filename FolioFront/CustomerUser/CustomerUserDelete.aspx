<%@ Page Title="" Language="C#" MasterPageFile="~/default_master.Master" AutoEventWireup="true" CodeBehind="CustomerUserDelete.aspx.cs" Inherits="FolioFront.CustomerUser.CustomerUserDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <form runat="server">
        <p>Are you Sure You Want To Delete This Record?</p>
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click"/>
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click"/>
    </form>
</asp:Content>
