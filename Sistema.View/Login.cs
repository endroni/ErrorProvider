using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidades;
using Sistema.Model;

namespace Sistema.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errUsuario.Icon = Properties.Resources.error;
                errUsuario.SetError(txtUsuario, "Usuario erro");
            }
            else
            {
                errUsuario.Icon = Properties.Resources.check;
                errUsuario.SetError(txtUsuario, "Ok");
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errSenha.Icon = Properties.Resources.error;
                errSenha.SetError(txtSenha, "Senha erro");
            }
            else
            {
                errSenha.Icon = Properties.Resources.check;
                errSenha.SetError(txtSenha, "Ok");
            }

            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o campo usuário!");
                    txtUsuario.Focus();
                    return;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Senha!");
                    txtSenha.Focus();
                    return;
                }

                UsuarioEnt obj = new UsuarioEnt();
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;

                obj = new UsuarioModel().Login(obj);

                if (obj.Usuario == null) 
                {
                    lblMensagem.Text = "Usuário ou senha não encontrado!";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }

                frmCadUsuario form = new frmCadUsuario() { telaprincipal = this};
                this.Hide(); 
                form.Show();
                // this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Logar" + ex.Message);
            }

        
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errUsuario.Icon = Properties.Resources.error;
                errUsuario.SetError(txtUsuario,"Usuario erro");
            }
            else
            {
                errUsuario.Icon = Properties.Resources.check;
                errUsuario.SetError(txtUsuario, "Ok");
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errSenha.Icon = Properties.Resources.error;
                errSenha.SetError(txtSenha, "Senha erro");
            }
            else
            {
                errSenha.Icon = Properties.Resources.check;
                errSenha    .SetError(txtSenha, "Ok");
            }
        }
    }
}
