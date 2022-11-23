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
    public partial class frmNacionalidade : Form
    { 
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidade()
        {
            InitializeComponent();
            dgvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrou = _nacionalidadeController.Cadastrar(txtDescricao.Text.ToUpper());
            if (cadastrou)
            {
                MessageBox.Show("Nacionalidade cadastrado com sucesso!", "Nacionalidade cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar uma nova nacionalidade", "Nacionalidade não cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var atualizou = _nacionalidadeController.AtualizarDado(id, txtDescricao.Text.ToUpper());
            if (atualizou)
            {
                MessageBox.Show("Nacionalidade atualizada com sucesso!", "Nacionalidade atualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao atualizar uma nacionalidade", "Nacionalidade não atualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletou = _nacionalidadeController.Deletar(id);
            if(deletou)
            {
                MessageBox.Show("Nacionalidade deletado com sucesso!", "Nacionalidade deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma nacionalidade", "Nacionalidade não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
