<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirUsuarios.aspx.cs" Inherits="Projeto3.Admin.ExibirUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-60">
        <asp:Button ID="NovoCadastro" OnClick="NovoCadastro_Click" runat="server" Text="Novo Cadastro" />
        <asp:Button ID="Fechar" OnClick="Fechar_Click" CssClass="botao-delete" runat="server" Text="Sair" />
        <hr />
        <div>
            <asp:GridView ID="GridViewUsuarios" Width="100%" AutoGenerateSelectButton="true" CellPadding="8"  BorderColor="Gray" OnSelectedIndexChanged="GridViewUsuarios_SelectedIndexChanged" runat="server"></asp:GridView>
        </div>
    </div>

</asp:Content>
