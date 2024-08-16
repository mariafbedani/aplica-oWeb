<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="Projeto3.FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row min-height-300px margin-top-60">
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Fale Conosco</h2>
                <br />
                <asp:Label ID="Alerta" ForeColor="Red" runat="server"></asp:Label>
                <asp:Panel ID="Formulario" runat="server">
                    <br />
                    <label>Nome</label>
                    <asp:TextBox ID="Nome" MaxLength="50" runat="server"></asp:TextBox>
                    <label>E-mail</label>
                    <asp:TextBox ID="Email" MaxLength="100" runat="server"></asp:TextBox>
                    <label>Telefone</label>
                    <asp:TextBox ID="Telefone" MaxLength="30" runat="server"></asp:TextBox>
                    <label>Mensagem</label>
                    <asp:TextBox ID="Mensagem" TextMode="MultiLine" Rows="6" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button OnClick="Enviar_Click" ID="Button1" runat="server" Text="Enviar" />
                </asp:Panel>
            </div>
        </div>
        <div class="col-6">
            <div class="box border">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3094.2401315642333!2d-47.351285792851826!3d-22.739672470853655!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana%20Ministro%20Ralph%20Biasi!5e0!3m2!1spt-BR!2sbr!4v1711546607644!5m2!1spt-BR!2sbr" width="100%" height="100%" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
            </div>
        </div>
    </div>
</asp:Content>
