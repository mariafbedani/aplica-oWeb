using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using AdsLib;
//ESTE CÓDIGO É UM EXEMPLO DE COMO ENVIAR EMAIL
namespace Projeto3
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            if(Nome.Text.Trim() =="") 
            {
                Alerta.Text = "Digite seu nome";
            }
            else if (Email.Text.Trim() == "")
            {
                Alerta.Text = "Digite seu e-mail";
            }
            else if (Mensagem.Text.Trim() == "")
            {
                Alerta.Text = "Digite sua mensagem";
            }
            else
            {
                try
                {
                    //Envia o email

                    //Cria uma instancia da classe MailMessage()  MailMessage=classe mail=variável que a gente vai criar dentro do MailMessage
                    MailMessage mail = new MailMessage();
                    mail.To.Add("contato@seudominio.com.br");
                    MailAddress from = new MailAddress
                        ("contato@seudominio.com.br");
                    mail.From = from;
                    mail.Subject = "Email enviado pela página fale conosco";
                    mail.Body = "Nome:" + Nome.Text + "\n";
                    mail.Body += "Email:" + Email.Text + "\n";
                    mail.Body += "Telefone:" + Telefone.Text + "\n";
                    mail.Body += "Mensagem:" + Mensagem.Text + "\n";
                    mail.IsBodyHtml = false;
                    //From, Subject, Body, IsBodyHtml= propriedades da classe MailMessage

                    //Cria uma instancia da classe SMTPClient() essa classe tbm percende ao System.NET.Mail smtp é um nome de um protocolo da internet (regras) p smtp vai transimitr o email. Host- propriedade de indica o provedor que vai enviar o email
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "seudominio.com.br";
                    smtp.Credentials = new System.Net.NetworkCredential
                        ("contato@seudominio.com.br", "suasenha");
                    //Envia o email  send=método que envia o email mail=variável smtp=variáel que a gnt acabou de criar dentro da classe SmtpClient
                    smtp.Send(mail); //send = método que vai enviar o email    mail= a variavel

                    Alerta.Text = "Seu e-mail foi enviado com sucesso";
                    Alerta.ForeColor = System.Drawing.Color.Green;
                    Formulario.Visible = false;
                }
                catch (Exception ex) //Quando há um problema ele vai executar o catch, e tds as infos do problema vao pra classe Exception. O Exception é uma classe, e criamos a variavel ex pra pegar da exception as propriedades que nos interessam. entao a ex é uma variavel tipo classe Exception
                {
                    Alerta.Text = "Houve uma falha ao enviar o email <br>Tente mais tarde ";
                    Formulario.Visible = false;

                    // Escreva as linhas de código abaixo para gravar (append) a mensagem no arquivo "LogExcecoes.txt" - tava aqui mas colocamos no TratamentoExcecao para ficar visivel para todos or programas

                    //string caminhoFisico = Server.MapPath("~/LogExcecoes.txt");

                    //System.IO.File.AppendAllText(caminhoFisico, ex.Message + " | " + ex.StackTrace "\n------------------------------");
                    //dentro do pacote systemio, a classe file abre um arquivo, o appendalltext abre ou cria um arquivo, que vai ser colocado no caminho fisico (que é o arq txt de logexcessao), e vai gravar as infos da variavel ex (a variavel ex foi atribuida anteriormente a classe exception, como essa classe tem varias atribuições, colocamos na frente qual que nós queremos que seja exibida, que nesse caso é o Message e o StackTrace 

                    // criar uma instancia da classe
                    TratamentoExcecoes tr = new TratamentoExcecoes();
                    tr.NomeArquivo = "NovoNome.txt";
                    tr.GravarExcecoes(ex);
                }
            }
        }
    }
}