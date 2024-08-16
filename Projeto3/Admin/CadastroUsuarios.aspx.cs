using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datapost.DB;

namespace Projeto3.Admin
{
    public partial class CadastroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["key"].ToString() != "")
                {
                    UsuarioID.Text = Request.QueryString["key"].ToString();
                    LerUsuario();
                }
            }
        }

        protected void LerUsuario()
        {
            DAO db = new DAO(); // DAO = obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb;

            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string comandoSQL = "SELECT * FROM Usuarios WHERE UsuarioId=" + UsuarioID.Text;

            DataTable dt = new DataTable();
            dt = (DataTable)db.Query(comandoSQL);
            if (dt.Rows.Count > 0)
            {
                Nome.Text = dt.Rows[0]["Nome"].ToString();
                Email.Text = dt.Rows[0]["Email"].ToString();
                NomeAcesso.Text = dt.Rows[0]["NomeAcesso"].ToString();
                Senha.Text = dt.Rows[0]["Senha"].ToString();
                Status.SelectedValue = dt.Rows[0]["Status"].ToString();
            }

        }


        protected bool ExisteNomeAcesso()

        {
            DAO db = new DAO(); // DAO = obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb;

            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string verificacao = "SELECT NomeAcesso, UsuarioID FROM Usuarios WHERE NomeAcesso ='" + NomeAcesso.Text+"'";
            DataTable data = new DataTable();
            data = (DataTable)db.Query(verificacao);
            if (data.Rows.Count > 0 && data.Rows[0]["UsuarioID"].ToString() != UsuarioID.Text)
            {
                Alerta.Text = "Nome de acesso já existente, digite outro nome";
                return true;
            }
            return false;
        }

        protected bool ExisteEmail()

        {
            DAO db = new DAO(); // DAO = obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb;

            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string verificacao = "SELECT Email, UsuarioID FROM Usuarios WHERE Email ='" + Email.Text + "'";
            DataTable data = new DataTable();
            data = (DataTable)db.Query(verificacao);
            if (data.Rows.Count > 0 && data.Rows[0]["UsuarioID"].ToString() != UsuarioID.Text)
            {
                Alerta.Text = "Esse email já está em uso, digite outro email";
                return true;
            }
            return false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool existeEmail = ExisteEmail();
            bool existeNomeAcesso = ExisteNomeAcesso();


            if (Nome.Text.Trim() == "")
            {
                Alerta.Text = "Digite o nome";
            }
            else if (Email.Text.Trim() == "")
            {
                Alerta.Text = "Digite o e-mail";
            }
            else if (NomeAcesso.Text.Trim() == "")
            {
                Alerta.Text = "Digite o nome de acesso";
            }
            else if (Senha.Text.Trim() == "")
            {
                Alerta.Text = "Digite a senha";
            }
            else if (!existeNomeAcesso && !existeEmail)
            {
                DAO db = new DAO(); // DAO = obj de acesso a dados

                db.DataProviderName = DAO.ProviderName.OleDb;

                db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

                String sql = "";
                if (UsuarioID.Text == "")
                {
                     sql = "INSERT INTO Usuarios(Nome,Email,NomeAcesso,Senha,Status) VALUES('" + Nome.Text + "','" + Email.Text + "','" + NomeAcesso.Text + "','" + Senha.Text + "'," + Status.SelectedValue + ");";
                }
                else
                {
                    sql = "UPDATE Usuarios SET Nome='" + Nome.Text + "',Email='" + Email.Text + "',NomeAcesso='" + NomeAcesso.Text + "',Senha='" + Senha.Text + "',Status=" + Status.SelectedValue +" WHERE UsuarioId="+UsuarioID.Text;
                }
                

                db.Query(sql);

                Response.Redirect("ExibirUsuarios.aspx");
            }
        }
    }
}