using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController(); 
        public frmNacionalidades()
        {
            InitializeComponent();
            txtId.Enabled = false;

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
            
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
