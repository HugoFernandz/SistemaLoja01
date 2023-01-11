﻿using SistemaLoja01.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaLoja01.Page
{
    public partial class Pessoas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Util util = new Util();
                util.ListaDropdown(ddlTipoCadastro, ((int)eTipoDrop.TipoCadastro));
                util.ListaDropdown(ddlBTipoCadastro, ((int)eTipoDrop.TipoCadastro));
                //Session["frmUsuarios"] = 0;

                DataTable data = new DataTable();

                data.Columns.Add("Nome");
                data.Columns.Add("cpf");
                data.Columns.Add("Contato");
                data.Columns.Add("Email");
                data.Columns.Add("TipoCadastro");

                data.Rows.Add("Joao", "10101010", "11987654321", "joao@hotmail.com", "Cliente");
                data.Rows.Add("Maria", "10101010", "11987654321", "maria@hotmail.com", "Colaborador");
                data.Rows.Add("Antonio", "10101010", "11987654321", "antonio@hotmail.com", "Cliente");

                //GridViewUsuarios.DataSource = Enum.GetNames(typeof(ePerfil));

                GridViewPessoas.DataSource = data;
                GridViewPessoas.DataBind();

            }
        }
        // grid de busca
        // editar
        protected void Cadastro_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = txtNome.Text;
            pessoa.cpf = Convert.ToInt64(TxtCPF.Text);
            pessoa.contato = Convert.ToInt64(txtContato.Text);
            pessoa.email = txtEmail.Text;
            pessoa.funcao = ddlTipoCadastro.SelectedIndex;

            //usuarios.login = txtLogin.Text;
            //usuarios.senha = txtSenha.Text;
            //usuarios.status = Convert.ToBoolean(Convert.ToInt32(rblStatus.SelectedValue));

            Limpa_Campos();
        }
        protected void Busca_Click(object sender, EventArgs e)
        {
            Usuario usuarios = new Usuario();
            Pessoa pessoa = new Pessoa();

            pessoa.nome = txtBNome.Text;
            pessoa.funcao = ddlBTipoCadastro.SelectedIndex;

            Limpa_Campos();


        }

        protected void Limpa_Campos()
        {
            if (TableCadastro.Visible)
            {
                txtNome.Text = string.Empty;
                TxtCPF.Text = string.Empty;
                txtContato.Text = string.Empty;
                txtEmail.Text = string.Empty;

                //txtLogin.Text = string.Empty;
                //txtSenha.Text = string.Empty;

                //rblStatus.SelectedIndex = -1;
                ddlTipoCadastro.SelectedIndex = -1;
            }

            if (TableBusca.Visible)
            {
                txtBNome.Text = string.Empty;
                ddlBTipoCadastro.SelectedIndex = 0;
            }
        }
    }
}