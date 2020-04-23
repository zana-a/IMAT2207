<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddPublisher.aspx.cs" Inherits="FolioFront.addEditDelete.AddPublisher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formPublisherFind" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <div class="p-2 mb-2">
                    <h1>Add Publisher</h1>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDPublisherName">
                        Publisher Name:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDPublisherName" runat="server" />
                    <asp:Label ID="lblErrorPubAEDName" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDPublisherDateFounded">
                        Publisher Date Founded:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDPublisherDateFounded" runat="server" />
                    <asp:Label ID="lblErrorPubAEDDateFounded" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="form-checkbox">
                        <label for="cbxPublisherIsActive">
                            Is Active
                            <asp:CheckBox ID="cbxAEDPublisherIsActive" runat="server" />
                        </label>
                    </div>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtAEDPublisherWebsite">
                        Publisher Website:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtAEDPublisherWebsite" runat="server"/>
                    <asp:Label ID="lblErrorPubAEDWebsite" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="clearfix">
                        <asp:Button CssClass="btn btn-primary" ID="btnOkay" runat="server" Text="Okay" OnClick="btnOkayAdd_Click" />
                        <asp:Button CssClass="btn btn-primary" ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancelAdd_Click" />                        
                    </div>
                    <div class="clearfix">
                        <asp:Label ID="lblErrorOkay" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
