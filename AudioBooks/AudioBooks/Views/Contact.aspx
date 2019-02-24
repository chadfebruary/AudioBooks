<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AudioBooks.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Chad February<br />
        <abbr title="Phone">P:</abbr>
        072 892 8941
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:chadfebruary@gmail.com">chadfebruary@gmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:chadfebruary@gmail.com">chadfebruary@gmail.com</a>
    </address>
</asp:Content>
