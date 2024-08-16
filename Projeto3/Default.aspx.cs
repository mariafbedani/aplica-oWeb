using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datapost.DB;

namespace Projeto3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAO comando = new DAO();

            comando.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";


            String sql = "INSERT INTO Usuarios(Nome,Email) VALUES('Jose da Silva','jose@dfgdfg.com');";

            comando.DataProviderName = DAO.ProviderName.OleDb;

            comando.Query(sql);
        }
    }
}