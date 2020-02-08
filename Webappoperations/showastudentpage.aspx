<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showastudentpage.aspx.cs" Inherits="Webappoperations.showastudentpage" %>

<asp:Content ID="cid" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="enter a studentg id"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="student" onClick="Button1_Click"/>
<br />
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>