<%@ Page Title="" Language="C#" MasterPageFile="~/empty_master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FolioFront.user.login" %>

<asp:Content ID="loginHead" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="loginContent" ContentPlaceHolderID="cphContent" runat="server">
    <div class="d-flex flex-column flex-items-center mt-6">
        <div class="py-2 mb-2 text-center">
            <span class="f1">Folio</span>
        </div>
        <div class=" mb-2 text-center">
            <span class="f2-light">Login to Folio</span>
        </div>
        <form id="formCustomerUserFind" runat="server" style="max-width: 340px;">
            <div class="form-group border clearfix rounded-2 p-4 bg-white">
                <div class="col-12 float-left py-2">
                    <label for="txtEmail" class="text-left">
                        Email:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtEmail" runat="server" />

                </div>
                <div class="col-12 float-left py-2">
                    <label for="txtPassword">
                        Password:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtPassword" runat="server" />

                </div>
                <div class="col-12 float-left py-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary width-full" ID="btnLogin" runat="server" Text="Login" />
                    </div>
                </div>
            </div>
        </form>
        <div class="border clearfix rounded-2 p-3 bg-white">
            Lost? Return to the <a href="/">Homepage</a>.
        </div>
        <footer class="border-top border-gray-light py-3 mt-3">
            <div class="d-flex flex-column flex-items-center">
                <div>&copy; <%= DateTime.Now.Year.ToString() %> <a href="/" class="text-bold text-blue">Folio</a>.  All rights reserved.</div>
                <div class="Header text-small px-0 text-center" style="background-color: transparent;">
                    <div class="Header-item">
                        <a href="/terms.aspx" class="no-underline text-gray link-hover-blue">Terms</a>
                    </div>
                    <div class="Header-item">
                        <a href="/privacy.aspx" class="no-underline text-gray link-hover-blue">Privacy</a>
                    </div>
                    <div class="Header-item">
                        <a href="/help.aspx" class="no-underline text-gray link-hover-blue">Help</a>
                    </div>
                    <div class="Header-item">
                        <a href="/about.aspx" class="no-underline text-gray link-hover-blue">About</a>
                    </div>
                </div>
            </div>
        </footer>
    </div>
</asp:Content>
