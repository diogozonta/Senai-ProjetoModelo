using AppModelo.Controller.Cadastros;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Deletar
{
    public partial class frmDeletarNacionalidade : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmDeletarNacionalidade()
        {
            InitializeComponent();
            var listanacionalidades = new NacionalidadeRepository();
            dgvNacionalidades.DataSource = listanacionalidades.ObterTodos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletou = _nacionalidadeController.Deletar(id);
            if(deletou)
            {
                MessageBox.Show("Dado deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var listanacionalidades = new NacionalidadeRepository();
                dgvNacionalidades.DataSource = listanacionalidades.ObterTodos();
            }
            else
            {
                MessageBox.Show("Problem ao deletar dado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
