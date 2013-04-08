<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.master" AutoEventWireup="true" CodeBehind="FundCurrentInput.aspx.cs" Inherits="WebApplication3.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Text="Fund Current"></asp:Label>
        &nbsp;</p>
    <p>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Cur Project IRR"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Cur Project WDP"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Cur Proj IRR (Leveraged)"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label5" runat="server" Text="Cur Proj WDP (Leveraged)"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Cur Equity Required"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Cur Pref Rate"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Cur Hurdle Rate"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Cur Split to Hurdle"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="Cur Split After Hurdle"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        &nbsp; &nbsp;<asp:Label ID="Label11" runat="server" Text="Cur Participation"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label12" runat="server" Text="Cur Investor IRR (Actual)"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label13" runat="server" Text="Cur Loan To Cost (%)"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label14" runat="server" Text="Current Debt"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Text="Current Interest"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label16" runat="server" Text="Current Loan Fee"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label17" runat="server" Text="Cur Appraisal"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label18" runat="server" Text="Cur Closing"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label19" runat="server" Text="Cur Int Reserve"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label20" runat="server" Text="Cur Release Price"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label21" runat="server" Text="Cur Budgeted Int"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label22" runat="server" Text="Cur Int To Date"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label23" runat="server" Text="Bank"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label24" runat="server" Text="Floor"></asp:Label>
        &nbsp;&nbsp;<asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
&nbsp;
       
         
        </p>
</asp:Content>
