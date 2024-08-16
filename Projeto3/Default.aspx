<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Referência do slide:  -->
    <!-- Place somewhere in the <body> of your page -->
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="Images/1.png" />
            </li>
            <li>
                <img src="Images/2.png" />
            </li>
            <li>
                <img src="Images/3.png" />
            </li>
            <li>
                <img src="Images/4.png" />
            </li>
        </ul>
    </div>
    <script>
        // Can also be used with $(document).ready()
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide"
            });
        });
    </script>

    <div class="row min-height-300px margin-top-60">
        <!-- COLUNA 1 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/Agência%20de%20Marketing%20Profissional%20Vinho%20e%20Branco.png" />
                <br />
                <h2>Tráfego Pago</h2>
                <br />
                <p>Maximize seu alcance online com nosso serviço de tráfego pago. Na Agency, utilizamos estratégias eficazes para aumentar visitas qualificadas ao seu site, convertendo cliques em resultados tangíveis.</p>
            </div>
        </div>
        <!-- COLUNA 2 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/Instagram%20post%20para%20marketing%20digital%20ousado%20azul.png" />
                <br />
                <h2>Design Gráfico</h2>
                <br />
                <p>Destaque sua marca com nosso design gráfico personalizado na Agency. Criamos desde logotipos marcantes até materiais de marketing que captam a essência do seu negócio. </p>
            </div>
        </div>
        <!-- COLUNA 3 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/Post%20do%20instagram%20para%20marketing%20digital%20ousado%20preto%20e%20rosa(2).png" />
                <br />
                <h2>Produção de Conteúdo</h2>
                <br />
                <p>Transforme sua estratégia digital com nosso serviço de produção de conteúdo. Criamos textos e mídias que engajam seu público-alvo, impulsionando seu crescimento online.</p>
            </div>
        </div>
        <!-- COLUNA 4 -->
        <div class="col-3">
            <div class="box border">
                <img width="100%" src="Images/Post%20do%20instagram%20para%20marketing%20digital%20ousado%20preto%20e%20rosa.png" />
                <br />
                <h2>Mídias Sociais</h2>
                <br />
                <p>Aumente seu impacto nas redes sociais com nosso serviço especializado. Criamos estratégias eficazes para aumentar sua visibilidade e engajamento. Transforme seguidores em clientes fiéis hoje mesmo!</p>
            </div>
        </div>
    </div>
</asp:Content>
