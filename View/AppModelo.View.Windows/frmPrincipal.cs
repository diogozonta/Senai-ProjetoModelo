using AppModelo.View.Windows.Atualizar;
using AppModelo.View.Windows.Cadastro;
using AppModelo.View.Windows.Deletar;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void nacionalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmAtualizarNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmAtualizarNaturalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void nacionalidadeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new frmDeletarNacionalidade();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new frmDeletarNaturalidade();
            form.MdiParent = this;
            form.Show();
        }
    }
}
