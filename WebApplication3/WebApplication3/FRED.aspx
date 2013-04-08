<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="FRED.aspx.cs" Inherits="WebApplication3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" 
            Text="FRED Database Updater"></asp:Label>
    
        <br />
    
    </div>
    <asp:Label ID="Label3" runat="server" Text="Updating"></asp:Label>
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Height="113px" Width="205px">
    </asp:ListBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Last Updated:  "></asp:Label>
    <asp:Label ID="UpDate" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" />
</asp:Content>
