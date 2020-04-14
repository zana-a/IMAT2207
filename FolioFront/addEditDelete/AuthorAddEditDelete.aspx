<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="AuthorAddEditDelete.aspx.cs" Inherits="FolioFront.AuthorCollection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formAuthorFind" runat="server">
            <div class="form-group border clearfix rounded-2 p-4"> 
                <div class="p-2 mb-2">
                    <asp:ListBox CssClass="form-control width-full" ID="lstAuthors" runat="server">

                    </asp:ListBox>
                </div>               
                <div class="col-12 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnAddAuthor" runat="server" Text="Add" OnClick="btnAddAuthor_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnDeleteAuthor" runat="server" Text="Delete" OnClick="btnDeleteAuthor_Click" />
                        <asp:Label ID="lblErrorAED" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                
            </div>
        </form>
    </div>
</asp:Content>
