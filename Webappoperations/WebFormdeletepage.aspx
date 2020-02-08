<%@ Page Language="C#" MasterPageFile="~/Site.Master"AutoEventWireup="true" CodeBehind="WebFormdeletepage.aspx.cs" Inherits="Webappoperations.WebFormdeletepage" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="SID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br/>
    <asp:Button runat="server" Text="Button" OnClick="Unnamed3_Click"></asp:Button>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </asp:Content>