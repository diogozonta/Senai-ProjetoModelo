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

namespace AppModelo.View.Windows.Atualizar
{
    public partial class frmAtualizarNaturalidades : Form
    {
        private NaturalidadeController _naturalidadecontroller = new NaturalidadeController();

        public frmAtualizarNaturalidades()
        {
            InitializeComponent();
            var listanaturalidades = new NaturalidadeRepository();
            dgvNaturalidades.DataSource = listanaturalidades.ObterTodasNaturalidades();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var salvou = _naturalidadecontroller.Atualizar(id, txtDescricao.Text.ToUpper());

            if (salvou)
            {
                MessageBox.Show("Dado atualizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var listanaturalidades = new NaturalidadeRepository();
                dgvNaturalidades.DataSource = listanaturalidades.ObterTodasNaturalidades();
            }
            else
            {
                MessageBox.Show("Problema ao atualizar dado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
