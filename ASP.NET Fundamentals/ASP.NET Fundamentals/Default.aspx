<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_Fundamentals._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblVisitas" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="lblKeyWebConfig" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Button ID="btnGenerarError" OnClick="DispararError" runat="server" Text="Generar Error"></asp:Button>
    </div>
</asp:Content>
