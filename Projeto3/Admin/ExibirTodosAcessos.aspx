<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirTodosAcessos.aspx.cs" Inherits="Projeto3.Admin.ExibirTodosAcessos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="margin-top-60">
    <asp:GridView ID="GridViewAcessos" CellPadding="8" BorderColor="#c0c0c0" Width="100%" runat="server"></asp:GridView>
  </div>
</asp:Content>
