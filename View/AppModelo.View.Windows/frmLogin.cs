using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "diogo@email.com";
            txtSenha.Text = "E16E4649";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;

            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "E-mail é inválido");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado");
            }

        }

        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
            this.Hide();
        }

    }
}
