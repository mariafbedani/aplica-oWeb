using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3.Admin
{
    public partial class CadastrodeCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request?.QueryString["key"]?.ToString() != "")
                {
                    ClienteID.Text = Request?.QueryString["key"]?.ToString();
                    
                    if (!String.IsNullOrEmpty(ClienteID.Text))
                        LerCliente();
                }
            }
        }

        protected void LerCliente()
        {
            DAO db = new DAO(); // DAO = obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb;

            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string comandoSQL = "SELECT * FROM Clientes WHERE ClienteId=" + ClienteID.Text;

            DataTable dt = new DataTable();
            dt = (DataTable)db.Query(comandoSQL);
            if (dt.Rows.Count > 0)
            {
                Nome.Text = dt.Rows[0]["Nome"].ToString();
                Email.Text = dt.Rows[0]["Email"].ToString();
                Numero.Text = dt.Rows[0]["Numero"].ToString();
                Complemento.Text = dt.Rows[0]["Complemento"].ToString();
                CEP.Text = dt.Rows[0]["CEP"].ToString();
                Tipo.SelectedValue = dt.Rows[0]["Tipo"].ToString();
                Documento.Text = dt.Rows[0]["Documento"].ToString();
                Telefone.Text = dt.Rows[0]["Telefone"].ToString();
            }

        }
        protected bool ExisteNome()

        {
            DAO db = new DAO(); // DAO = obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb;

            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string verificacao = "SELECT Nome, ClienteID FROM Clientes WHERE Nome ='" + Nome.Text + "'";
            DataTable data = new DataTable();
            data = (DataTable)db.Query(verificacao);
            if (data.Rows.Count > 0 && data.Rows[0]["ClienteID"].ToString() != ClienteID.Text)
            {
                Alerta.Text = "Cliente já cadastrado";
                return true;
            }
            return false;
        }
        protected void Salvar_Click(object sender, EventArgs e)
        {
            bool existeNome = ExisteNome();

            if (Tipo.SelectedValue == "1")
            {
                CNPJouCPF.Text = "CPF";
            }
            if (Nome.Text.Trim() == "")
            {
                Alerta.Text = "Digite o nome";
            }
            else if (Email.Text.Trim() == "")
            {
                Alerta.Text = "Digite o e-mail";
            }
            else if (Tipo.Text.Trim() == "")
            {
                Alerta.Text = "Digite o tipo do cliente";
            }
            else if (Numero.Text.Trim() == "")
            {
                Alerta.Text = "Digite o número";
            }
            else if (CEP.Text.Trim() == "")
            {
                Alerta.Text = "Digite o CEP";
            }
            else if (Telefone.Text.Trim() == "")
            {
                Alerta.Text = "Digite o telefone";
            }
            else if (!existeNome)
            {
                DAO db = new DAO(); // DAO = obj de acesso a dados

                db.DataProviderName = DAO.ProviderName.OleDb;

                db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

                String sql = "";
                if (ClienteID.Text == "")
                {
                    sql = @"INSERT INTO Clientes(Nome,Email,CEP,Complemento,Tipo,Numero,Documento,Telefone) " +
                          "VALUES('" + Nome.Text + "','" + Email.Text + "','" + CEP.Text+ "','" + Complemento.Text +
                          "'," + Tipo.SelectedValue + ",'" + Numero.Text + "','" + Documento.Text + "','" + Telefone.Text + "');";
                }
                else
                {
                    sql = @"UPDATE Clientes SET Nome = '" + Nome.Text + "',Email='" + Email.Text + "',CEP='" + CEP.Text + "', Numero='" 
                          + Numero.Text + "',Tipo=" + Tipo.SelectedValue + ", Telefone='" + Telefone.Text + "' ,Complemento='" + Complemento.Text + 
                          "' ,Documento='" + Documento.Text + "' WHERE ClienteId=" + ClienteID.Text;
                }


                db.Query(sql);

                Response.Redirect("ExibirClientes.aspx");
            }
        }

        protected void TipoSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tipo.SelectedValue == "1")
            {
                CNPJouCPF.Text = "CPF";
            }
            else if (Tipo.SelectedValue == "0")
            {
                CNPJouCPF.Text = "CNPJ";
            }
            else
            {
                CNPJouCPF.Text = "";
            }
        }

    }
}