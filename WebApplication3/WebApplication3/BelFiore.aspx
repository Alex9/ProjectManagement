<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="BelFiore.aspx.cs" Inherits="WebApplication3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Enter Belfiore Excel File"></asp:Label>
    <br />
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button4" runat="server" Text="Update" />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Last Updated:  "></asp:Label>
    <asp:Label ID="BelDate" runat="server"></asp:Label>
    <br />
<br />
<asp:Label ID="Label4" runat="server" Text="Updating"></asp:Label>
<br />
<asp:ListBox ID="ListBox1" runat="server" Width="350px"></asp:ListBox>
    <br />
</asp:Content>
