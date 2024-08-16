<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarios.aspx.cs" Inherits="Projeto3.Admin.CadastroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="box border margin-top-60">
                <h2>Cadastro de Usuário</h2>
                <br />
                <asp:Label ID="Alerta" runat="server"></asp:Label>
                <br />

                <asp:Label ID="UsuarioID" runat="server" Font-Size="20px" ></asp:Label>
                <br />

                <label>Nome</label>
                <!-- esse max lenght tem que ser do mesmo tamanho que foi definido la na tabela do banco -->
                <asp:TextBox ID="Nome" MaxLength="60" runat="server"></asp:TextBox>
                <label>Email</label>
                <asp:TextBox ID="Email" MaxLenght="255" runat="server"></asp:TextBox>
                <label>Nome de Acesso</label>
                <asp:TextBox ID="NomeAcesso" MaxLength="45" runat="server"></asp:TextBox>
                <label>Senha</label>
                <asp:TextBox ID="Senha" MaxLength="45" runat="server"></asp:TextBox>
                <label>Situação</label>
                <asp:DropDownList ID="Status" runat="server">
                    <asp:ListItem Text="Ativo" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Inativo" Value="0"></asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Salvar" OnClick="Button1_Click" runat="server" Text="Salvar" />
            </div>

        </div>

    </div>
</asp:Content>
