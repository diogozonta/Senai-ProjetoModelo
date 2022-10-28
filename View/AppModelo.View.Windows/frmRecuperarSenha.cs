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
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnRecuperarAcesso_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;

            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "E-mail é inválido");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtEmail.Text);
            MessageBox.Show(resultado);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            form.Show();
            this.Hide();
        }
    }
}
