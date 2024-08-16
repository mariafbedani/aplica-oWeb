﻿using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3.Admin
{
    public partial class ExibirUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LerUsuarios();
        }

        protected void LerUsuarios()
        {
            DAO db = new DAO(); // DAO =  object data access - obj de acesso a dados

            db.DataProviderName = DAO.ProviderName.OleDb; //OleDb é o provedor que vamos utilizar (access)

            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.Accdb") + ";Persist Security Info=False;";

            string comandoSQL = "SELECT UsuarioID,Nome,Email,NomeAcesso,Status FROM Usuarios ORDER BY Nome ASC ";
                //dps do select eu poderia colocar um * para trazer todos os campos mas como eu  quero que apareça a senha eu tive que escrever um por um, em ordem

            GridViewUsuarios.DataSource = db.Query(comandoSQL);
            GridViewUsuarios.DataBind();
        }

        protected void NovoCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroUsuarios.aspx?key="); //nao precisa do ~/ pq o cadastro usuarios ja esta dentro da pasta admin || ?key é uma variavel que estamos criando para passar a chave primaria pra ela
        }

        protected void GridViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chave = GridViewUsuarios.SelectedRow.Cells[1].Text; // no grid view vai pegar a celula 1 da linha que vc selecionar, que eh a celula do id, nossa chave primaria

            Response.Redirect("CadastroUsuarios.aspx?key=" + chave);

        }

        protected void Fechar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}