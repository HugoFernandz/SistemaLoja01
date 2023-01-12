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
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Util util = new Util();
                util.ListaDropdown(ddlTipoUsuario, ((int)eTipoDrop.TipoUsuario));
                util.ListaDropdown(ddlBTipoUsuario, ((int)eTipoDrop.TipoUsuario));
                //Session["frmUsuarios"] = 0;

                DataTable data = new DataTable();

                data.Columns.Add("Nome");
                data.Columns.Add("CPF");
                data.Columns.Add("Contato");
                data.Columns.Add("Email");
                data.Columns.Add("Login");
                data.Columns.Add("Senha");
                data.Columns.Add("Status");
                data.Columns.Add("Perfil");

                data.Rows.Add("Joao","10101010","11987654321","joao@hotmail.com","login1","senha1","Ativo","Administrador");
                data.Rows.Add("Maria","10101010","11987654321","maria@hotmail.com","login2","senha2","Ativo","Administrador");
                data.Rows.Add("Antonio","10101010","11987654321","antonio@hotmail.com","login3","senha3","Ativo","Colaborador");

                //GridViewUsuarios.DataSource = Enum.GetNames(typeof(ePerfil));
                GridViewUsuarios.DataSource = data;
                GridViewUsuarios.DataBind();
            }
        }
        // grid de busca
        // editar
        protected void Cadastro_Click(object sender, EventArgs e)
        {
            Usuario usuarios = new Usuario();
            Pessoa pessoa = new Pessoa();

            pessoa.nome = txtNome.Text;
            pessoa.cpf = Convert.ToInt64(TxtCPF.Text);
            pessoa.contato = Convert.ToInt64(txtContato.Text);
            pessoa.email = txtEmail.Text;
            //pessoa.status = Convert.ToBoolean(Convert.ToInt32(rblStatus.SelectedValue));

            usuarios.pessoa = pessoa;
            usuarios.login = txtLogin.Text;
            usuarios.senha = txtSenha.Text;
            usuarios.tipousuario = ddlTipoUsuario.SelectedIndex;

            Limpa_Campos();
        }
        protected void Busca_Click(object sender, EventArgs e)
        {
            Usuario usuarios = new Usuario();
            Pessoa pessoa = new Pessoa();

            pessoa.nome = txtBNome.Text;
            usuarios.pessoa = pessoa;
            usuarios.tipousuario = ddlBTipoUsuario.SelectedIndex;

            Limpa_Campos();


        }
        protected void Alterar_Click(object sender, EventArgs e)
        {
            Usuario usuarios = new Usuario();
            Pessoa pessoa = new Pessoa();

            pessoa.nome = txtANome.Text;
            pessoa.cpf = Convert.ToInt64(txtACPF.Text);
            pessoa.contato = Convert.ToInt64(txtAContato.Text);
            pessoa.email = txtAEmail.Text;
            pessoa.status = Convert.ToBoolean(Convert.ToInt32(rblAStatus.SelectedValue));

            usuarios.pessoa = pessoa;
            usuarios.tipousuario = ddlATipoUsuario.SelectedIndex;

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
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;

                ddlTipoUsuario.SelectedIndex = 0;
            }

            if (TableBusca.Visible)
            {
                txtBNome.Text = string.Empty;
                ddlBTipoUsuario.SelectedIndex = 0;
            }

            if (TableAlterar.Visible)
            {
                txtANome.Text = string.Empty;
                txtACPF.Text = string.Empty;
                txtAContato.Text = string.Empty;
                txtAEmail.Text = string.Empty;

                ddlTipoUsuario.SelectedIndex = 0;
                rblAStatus.SelectedIndex = -1;
            }
        }
    }
}