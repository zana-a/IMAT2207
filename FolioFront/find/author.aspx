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
                    <label for="txtFindAuthorId">
                        Author ID:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindAuthorId" runat="server" />
                    <asp:Label ID="lblErrorFindFindId" runat="server" Text=""></asp:Label>
                                                           
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindAuthorName">
                        Author Name:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindAuthorName" runat="server" />
                    <asp:Label ID="lblErrorFindName" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="imgFindAuthorImage">
                        Author Image:
                    </label>
                    <asp:Image id="imgFindAuthorImage" runat="server" ImageAlign="Left"/>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindAuthorDob">
                        Author DOB:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindAuthorDob" runat="server" />
                    <asp:Label ID="lblErrorFindDob" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-6 float-left p-2">
                    <label for="txtFindAuthorDesc">
                        Author Description:
                    </label>
                    <asp:TextBox CssClass="form-control width-full" ID="txtFindAuthorDesc" runat="server" TextMode="MultiLine" Rows="5" />
                    <asp:Label ID="lblErrorFindDesc" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-12 float-left p-2">
                    <div class="form-checkbox">
                        <label for="cbxAuthorIsAlive">
                            Is Alive
                            <asp:CheckBox ID="cbxFindAuthorIsAlive" runat="server" />
                        </label>
                    </div>
                </div>
                <div class="col-12 float-left p-2">
                    <asp:Button CssClass="btn btn-primary" ID="btnFind" runat="server" Text="Find" OnClick="btnFindAuthor_Click" />
                </div>
            </div>
        </form>
    </div>
</asp:Content>