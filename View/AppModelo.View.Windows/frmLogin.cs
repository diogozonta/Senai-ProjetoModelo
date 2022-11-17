using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppModelo.View.Windows
{

    public partial class frmLogin : Form
    {
        //Crio uma variável global para colocar no txtEmail
        public static string SetNomeUsuario = "";
        public static string HoraLogin = "";

        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "diogo@email.com";
            txtSenha.Text = "E16E4649";

            HoraLogin = DateTime.Now.ToString("u");
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
                //Coloco o txtEmail dentro da variável global para passar para o frmPrincipalNovo
                SetNomeUsuario = txtEmail.Text;

                var form = new frmPrincipalNovo();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Confira o e-mail/senha e tente novamente.", "E-mail ou senha não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(170, 57, 57);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.White;
        }
    }
}
