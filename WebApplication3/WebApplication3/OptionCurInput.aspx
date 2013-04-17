<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.master" AutoEventWireup="true" CodeBehind="OptionCurInput.aspx.cs" Inherits="WebApplication3.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:Label ID="Label4" runat="server" Font-Size="X-Large" 
            Text="Option Current"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Current Roll Price"></asp:Label>&emsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Other Lot Revenue"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="Label3" runat="server" Text="Cur Option Deposit"></asp:Label>&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />

        <asp:Label ID="Label5" runat="server" Text="Management Fee"></asp:Label>&nbsp;&emsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
</asp:Content>
