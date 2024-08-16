using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistrarAcessos(int userId, DAO db)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // especificação do formato da data
            string sql = "INSERT INTO RegistroAcessos(UsuarioID, DataHoraAcesso) VALUES('" + userId + "', '" + currentDateTime + "');";
            db.Query(sql); // executa o comando sql
           
        }

        protected void Entrar_Click(object sender, EventArgs e)
        {
            DAO db = new DAO(); // DAO = obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb;
                
            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string verificacao = "SELECT NomeAcesso, UsuarioID, Senha FROM Usuarios WHERE NomeAcesso ='" + NomeAcesso.Text + "' AND Senha='" + Senha.Text + "' AND Status=1";

            DataTable data = new DataTable();
            data = (DataTable)db.Query(verificacao);


            if (data.Rows.Count == 1)
            {
                // Cria a variavel de sessão para identificar se o usuário está autenticado para
                // permitir a exibição das opções do menu.
                Session["autenticado"] = "";
                // 1. Inicializa a classe de autenticação
                System.Web.Security.FormsAuthentication.Initialize();
                // 2. CRIAR O TICKET (define o tempo q o user pode ficar sem mexer no programa e nao precisar fazer o login novamente, nesse caso é 20 min)
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "admin",
               DateTime.Now, DateTime.Now.AddMinutes(20), false,
               FormsAuthentication.FormsCookiePath);
                // 3. CRIPTOGRAFA P TICKET E GRAVAR NO COOKIE DO NAVEGADOR
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName,
               FormsAuthentication.Encrypt(ticket)));
                // Redireciona para o form que o usuário tentou acessar

                int userId = data.Rows[0]["UsuarioID"].GetHashCode();
                RegistrarAcessos(userId, db);
                

                Response.Redirect(FormsAuthentication.GetRedirectUrl("Admin", false));
                

            }
            else
            {
                Msg.Text = "Dados de acesso invalidos";
            }
        }
    }
}