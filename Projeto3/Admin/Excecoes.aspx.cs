using AdsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3
{
    public partial class Excecoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TratamentoExcecoes tratamentoexcecoes = new TratamentoExcecoes(); //estanciando a classe, se nao os metodos dela nao vao aparecer
            ExecoesEx.Text = tratamentoexcecoes.LerExcecoes().Replace("\n", "<br/>"); //ExcecoesEx é o ID da label que vai exibir as exceções
        }

        protected void Limpar_Click(object sender, EventArgs e)
        {
            TratamentoExcecoes excluir = new TratamentoExcecoes();
            excluir.ExcluirArquivo();

            Response.Redirect("Excecoes.aspx");
        }
    }
}