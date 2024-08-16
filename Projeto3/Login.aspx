<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto3.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3">
            <div class="box border margin-top-60">
                <h2>ENTRADA</h2>
                <br />
                <asp:Label ID="Msg" ForeColor="red" runat="server"></asp:Label>
                <br />
                <label>Nome de Acesso</label>
                <asp:TextBox ID="NomeAcesso" MaxLength="69" runat="server"></asp:TextBox>
                <label>Senha</label>
                <asp:TextBox ID="Senha" TextMode="Password" MaxLength="30" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Entrar" OnClick="Entrar_Click" runat="server" Text="Entrar" />
            </div>
        </div>
    </div>
</asp:Content>
