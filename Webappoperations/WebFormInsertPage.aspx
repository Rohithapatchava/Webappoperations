<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormInsertPage.aspx.cs" Inherits="Webappoperations.WebFormInsertPage" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran">
        <asp:Label ID="Label1" runat="server" Text="studentid"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="startdate"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>

