<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AudioBooks._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">Upload audio book<asp:FileUpload ID="FileUpload" runat="server" />
        </p>
        &nbsp;</div>

    <footer>
        <div style="float:right">
            <asp:Button type="submit" class="btn btn-primary btn-lg" value="Upload" id="UploadFile" OnClick="UploadFile_Click" Text="Upload" runat="server" />

        </div>
    </footer>

</asp:Content>
