<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="AuthorAddEditDelete.aspx.cs" Inherits="FolioFront.AuthorCollection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formAuthorAED" runat="server">
            <div class="form-group border clearfix rounded-2 p-4"> 
                <h1>List of Authors</h1>
                If you wish to add a publisher click <a href="/addEditDelete/Publisher/PublisherAddEditDelete.aspx">here</a>
                <div class="p-2 mb-2">
                    <asp:ListBox CssClass="form-control" Width="316px" ID="lstAuthors" runat="server" Height="234px">
                    </asp:ListBox>
                </div>               
                <div class="col-12 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnAddAuthor" runat="server" Text="Add" OnClick="btnAddAuthor_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnEditAuthor" runat="server" Text="Edit" OnClick="btnEditAuthor_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnDeleteAuthor" runat="server" Text="Delete" OnClick="btnDeleteAuthor_Click" />                        
                    </div>
                    <div class="clearfix">
                        <asp:Label ID="lblErrorAED" runat="server" Text=""></asp:Label>                        
                    </div>
                </div>                
            </div>            
        </form>
    </div>    
</asp:Content>
