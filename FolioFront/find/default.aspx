<%@ Page Title="" Language="C#" MasterPageFile="~/default_master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FolioFront.find._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <h1>Find Page</h1>
        <p>Select one of the links to use the find method:</p>

        <ul>
            <li><a href="/find/customer.aspx">Customer</a></li>
        </ul>

        <ul>
            <li><a href="author.aspx">Author</a></li>
        </ul>

        <ul>
            <li><a href="publisher.aspx">Publisher</a></li>
        </ul>
    </div>
</asp:Content>
