using Projeto3.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["autenticado"] != null)
            {
                Login.Visible = false;
                Logout.Visible = true;
                Excecoes.Visible = true;
                ExibirUsuarios.Visible = true;
                ExibirClientes.Visible = true;
                ExibirTodosAcessos.Visible = true;
                CadastroAlunos.Visible = true;
            }
            else
            {
                Login.Visible=true;
                Logout.Visible=false;
                Excecoes.Visible=false;
                ExibirClientes.Visible = false;
                ExibirTodosAcessos.Visible = false;
                CadastroAlunos.Visible = false;
                ExibirUsuarios.Visible = false;
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");

        }
    }
}