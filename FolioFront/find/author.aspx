<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="author.aspx.cs" Inherits="FolioFront.Author" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formAuthorFind" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <div class="p-2 mb-2">
                    <h1>Find Author</h1>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAuthorId">
                        Author ID:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAuthorId" runat="server" />
                    <asp:Label ID="lblErrorId" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAuthorName">
                        Author Name:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAuthorName" runat="server" />
                    <asp:Label ID="lblErrorName" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAuthorDob">
                        Author DOB:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAuthorDob" runat="server" />
                    <asp:Label ID="lblErrorDob" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="form-checkbox">
                        <label for="txtAuthorIsAlive">
                            Is Alive
                            <asp:CheckBox ID="txtAuthorIsAlive" runat="server" />
                        </label>
                    </div>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnFind" runat="server" Text="Find" OnClick="btnFindAuthor_Click" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>