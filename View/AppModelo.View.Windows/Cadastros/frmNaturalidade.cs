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

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            dgvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrou = _naturalidadeController.Cadastrar(txtDescricao.Text.ToUpper(), chbAtivo.Checked);
            if (cadastrou)
            {
                MessageBox.Show("Naturalidade cadastradada com sucesso!", "Naturalidade cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar uma nova naturalidade", "Naturalidade não cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var atualizou = _naturalidadeController.Atualizar(id, txtDescricao.Text.ToUpper());
            if (atualizou)
            {
                MessageBox.Show("Naturalidade atualizada com sucesso!", "Naturalidade atualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao atualizar uma naturalidade", "naturalidade não atualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletou = _naturalidadeController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Dado deletado com sucesso!", "Naturalidade deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma naturalidade", "naturalidade não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
