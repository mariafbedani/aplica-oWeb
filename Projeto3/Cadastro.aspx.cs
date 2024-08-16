using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Projeto3
{
    public partial class Cadastro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Alunos.Text = LerAlunos();
        }

        protected string LerAlunos()
        {
            string caminhoFisico = Server.MapPath("~/CadastroAlunos.txt");
            // LEIA O ARQUIVO E ATRIBUA AO LABEL "ALUNOS"
            return File.ReadAllText(caminhoFisico).Replace("\n", "<br>");
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            if (Nome.Text == "")
            {
                Mensagem.Text = "Digite seu nome";
            }
            else if (Email.Text == "")
            {
                Mensagem.Text = "Digite seu e-mail";
            }
            else if (!int.TryParse(Idade.Text, out _))
            {
                Mensagem.Text = "Digite sua idade";
            }
            else
            {
                // define o conteúdo que será gravado
                string conteudo = "";
                conteudo = Nome.Text + "\n";
                conteudo += Email.Text + "\n";
                conteudo += Idade.Text + "\n";
                conteudo += "-----------------------------------------\n";

                // Identifica o caminho físico para gravar o arquivo
                string caminhoFisico = Server.MapPath("~/CadastroAlunos.txt");

                // executa o método para gravar o conteúdo no caminho físico
                System.IO.File.AppendAllText(caminhoFisico, conteudo);

                Nome.Text = "";
                Email.Text = "";
                Idade.Text = "";
                Mensagem.Text = "";

                Alunos.Text = LerAlunos();
            }
        }
    }
}