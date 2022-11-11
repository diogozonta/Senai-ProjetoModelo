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
    public partial class frmDeletarNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmDeletarNaturalidade()
        {
            InitializeComponent();
            var listaNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            dgvNaturalidades.DataSource = listaNaturalidades;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var salvou = _naturalidadeController.Deletar(id);
            if(salvou)
            {
                MessageBox.Show("Dado deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var listaNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
                dgvNaturalidades.DataSource = listaNaturalidades;
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar o dado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
