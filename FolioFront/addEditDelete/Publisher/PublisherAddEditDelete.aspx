<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="PublisherAddEditDelete.aspx.cs" Inherits="FolioFront.addEditDelete.PublisherAddEditDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formPublisherAED" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <h1>List of Publishers</h1>
                If you wish to add an author click <a href="/addEditDelete/Author/AuthorAddEditDelete.aspx">here</a>
                <div class="p-2 mb-2">                  
                    <asp:ListBox CssClass="form-control" Width="316px" ID="lstPublishers" runat="server" Height="234px">
                    </asp:ListBox>
                </div>               
                <div class="col-11 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnAddPublisher" runat="server" Text="Add" OnClick="btnAddPublisher_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnEditPublisher" runat="server" Text="Edit" OnClick="btnEditPublisher_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnDeletePublisher" runat="server" Text="Delete" OnClick="btnDeletePublisher_Click" />                        
                    </div>
                    <div class="clearfix">
                        <asp:Label ID="lblErrorPubAED" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="col-12 float-left p-2">
                    <p>Enter a name :</p>                    
                    <asp:TextBox CssClass="form-control width-md-auto" ID="txtFilterPublisher" runat="server" />                    
                    <asp:Button CssClass="btn btn-primary" ID="btnApplyFilter" runat="server" Text="Apply" OnClick="btnApplyPubFilter_Click" />
                    <asp:Button CssClass="btn btn-primary" ID="btnClearFilter" runat="server" Text="Clear" OnClick="btnClearPubFilter_Click" />
                </div>
                
            </div>
        </form>
    </div>
</asp:Content>

