using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmNacionalidades : Form
    {
        public frmNacionalidades()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var controller = new NacionalidadeController();
            var salvou = controller.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }
    }
}
