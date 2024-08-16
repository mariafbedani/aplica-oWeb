<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Excecoes.aspx.cs" Inherits="Projeto3.Excecoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row min-height-300px margin-top-120 margin-bottom-120">
        <!-- COLUNA 1 -->
        <div class="col-12">
            <div class="box border">
                <h2>Exibição de Exceções</h2>
                <br />
                <asp:Label ID="ExecoesEx" runat="server"></asp:Label>
                <br />
                <hr />
                <asp:Button ID="Limpar" OnClick="Limpar_Click" runat="server" Text="Limpar Arquivo" />
            </div>
        </div>
    </div>
</asp:Content>
