<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="AuthorAddEditDelete.aspx.cs" Inherits="FolioFront.AuthorCollection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formAuthorFind" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <div class="p-2 mb-2">
                    <h1>Add Author</h1>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDAuthorId">
                        Author ID:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDAuthorId" runat="server" />
                    <asp:Label ID="lblErrorAEDId" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDAuthorName">
                        Author Name:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDAuthorName" runat="server" />
                    <asp:Label ID="lblErrorAEDName" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDAuthorDob">
                        Author DOB:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDAuthorDob" runat="server" />
                    <asp:Label ID="lblErrorAEDDob" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDAuthorDesc">
                        Author Description:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDAuthorDesc" runat="server" TextMode="MultiLine" Rows="5" />
                    <asp:Label ID="lblErrorAEDDesc" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="form-checkbox">
                        <label for="cbxAuthorIsAlive">
                            Is Alive
                            <asp:CheckBox ID="cbxAEDAuthorIsAlive" runat="server" />
                        </label>
                    </div>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnAddAuthor" runat="server" Text="Add" OnClick="btnAddAuthor_Click" />
                        <asp:Label ID="lblErrorAED" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
