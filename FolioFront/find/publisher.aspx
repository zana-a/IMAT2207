<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="publisher.aspx.cs" Inherits="FolioFront.find.publisher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formPublisherFind" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <div class="p-2 mb-2">
                    <h1>Find Publisher</h1>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindPubId">
                        Publisher ID:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindPublisherId" runat="server" />
                    <asp:Label ID="lblErrorFindPubId" runat="server" Text=""></asp:Label>
                    <asp:Button CssClass="btn btn-primary" ID="btnFind" runat="server" Text="Find" OnClick="btnFindPublisher_Click" />
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindPubName">
                        Publisher Name:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindPubName" runat="server" />
                    <asp:Label ID="lblErrorFindPubName" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindPubDateFounded">
                        Publisher Date Founded:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindPubDateFounded" runat="server" />
                    <asp:Label ID="lblErrorFindPubDateFounded" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="form-checkbox">
                        <label for="cbxPubIsActive">
                            Is Active
                            <asp:CheckBox ID="cbxFindPubIsActive" runat="server" />
                        </label>
                    </div>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindPubWebsite">
                        Publisher Website:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindPubWebsite" runat="server"/>
                    <asp:Label ID="lblErrorFindPubWebsite" runat="server" Text ="" />
                </div>
                <div class="col-12 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnOk" runat="server" Text="Ok" OnClick="btnOkPublisher_Click" />                    
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
