using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3.Admin
{
    public partial class ExibirTodosAcessos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExibirAcessos();
        }

        protected void ExibirAcessos()
        {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

            string comando = "SELECT Usuarios.UsuarioID, DataHoraAcesso, Nome, Email FROM Usuarios,RegistroAcessos WHERE Usuarios.UsuarioID = RegistroAcessos.UsuarioID ORDER BY DataHoraAcesso DESC ";

            GridViewAcessos.DataSource = db.Query(comando);
            GridViewAcessos.DataBind();
        }
    }
}