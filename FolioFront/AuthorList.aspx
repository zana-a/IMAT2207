<%@ Page MasterPageFile="~/default_master.Master" Language="C#" AutoEventWireup="true" CodeBehind="AuthorList.aspx.cs" Inherits="FolioFront.AuthorList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="container-lg">
        <form id="formAuthorList" runat="server">
            <div class="form-group border clearfix rounded-2 p-4">
                <div class="p-2 mb-2">
                    <asp:ListBox runat="server">

                    </asp:ListBox>
                </div>
            </div>
        </form>
    </div>
</asp:Content>

