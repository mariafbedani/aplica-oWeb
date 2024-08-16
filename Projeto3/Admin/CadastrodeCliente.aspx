<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrodeCliente.aspx.cs" Inherits="Projeto3.Admin.CadastrodeCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cadastro de Cliente</h2>
    <!-- Adc seguinte tabela no banco de dados - Nome: Clientes
        Cliente ID - chave primária (auto incremento) 
        Fisica/Jurídica (numero) (0 = fisica | 1 - juridica) (USAR UM DROPDOWN LIST OU CHECKBOX LIST IGUAL USAMOS 
        NO STATUS)
        Nome  (texto curto)
        Email (texto curto)
        Telefone (texto curto)
        CNPJ (texto curto) / CPF pra pessoa fisica
        CEP (texto curto)
        Numero (texto curto)
        Complemento (texto curto) 
        Entregar até dia 25/06/2024
        o ExibirClientes pode ser igual o Exibir usuarios e editar usuarios, esse só vai ter mais dados
        que o Diógenes criou
        Todos são campos obrigatórios
        1 - criar uma tabela no banco de dadoa BacnodeDados.accdb
        2 - fazer o form para exibir os cliente (ja criamos a pag ExibirClientes.aspx (fazer uma tabela pra pessoa
        física e outra pra pessoa jurídica)
        3 - Criar o Form para INSERIR /EDITAR clientes (já criamos a pag CadastrodeCliente.aspx) (na hora de editar eu
        exibo o nome da rua. estado, etc)
        4 - Editar o form "Default.aspx" deixando-o com os dados/aparência da sua empresa (só HTML/CSS)

        Colocar no site (o conteudo que vc sobre é oq ta dentro d apasta projeto 3)
        Depois que fizer as pastar novas, tem q botar as pastas novas no file zilla se nao nao vai atualizar
        -->
    <div class="row">
        <div class="col-6">
            <div class="box border margin-top-60">
                <h2>Cadastro de Cliente</h2>
                <br />
                <asp:Label ID="Alerta" runat="server"></asp:Label>
                <br />

                <asp:Label ID="ClienteID" runat="server" Font-Size="20px"></asp:Label>
                <br />

                <label>Tipo</label>
                <asp:DropDownList ID="Tipo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="TipoSelectedIndexChanged">
                    <asp:ListItem Text="Físico" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Jurídico" Value="0"></asp:ListItem>
                </asp:DropDownList>

                <label>Nome</label>
                <!-- esse max lenght tem que ser do mesmo tamanho que foi definido la na tabela do banco -->
                <asp:TextBox ID="Nome" MaxLength="255" runat="server"></asp:TextBox>
                <label>Email</label>
                <asp:TextBox ID="Email" MaxLenght="255" runat="server"></asp:TextBox>
                <label>Telefone</label>
                <asp:TextBox ID="Telefone" MaxLength="11" runat="server"></asp:TextBox>

                <label></label>
                <asp:Label ID="CNPJouCPF" Text="CPF" runat="server" ></asp:Label>

                <asp:TextBox ID="Documento" MaxLength="255" runat="server"></asp:TextBox>
                <label>CEP</label>
                <asp:TextBox ID="CEP" MaxLength="255" runat="server"></asp:TextBox>
                <label>Número</label>
                <asp:TextBox ID="Numero" MaxLength="255" runat="server"></asp:TextBox>
                <label>Complemento</label>
                <asp:TextBox ID="Complemento" MaxLength="255" runat="server"></asp:TextBox>


                <asp:Button ID="Salvar" OnClick="Salvar_Click" runat="server" Text="Salvar" />
            </div>

        </div>

    </div>
</asp:Content>
