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

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmAtualizarNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmAtualizarNacionalidades()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var atualizarDado = _nacionalidadeController.AtualizarDado(id, txtDescricao.Text);

            if (atualizarDado = true)
            {
                MessageBox.Show("Dado atualizado com sucesso", "Sucesso ao atualizar!" + MessageBoxIcon.Information + MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Problema ao conectar com banco de dados", "Problema ao atualizar!!" + MessageBoxIcon.Error + MessageBoxButtons.OK);

            }
        }
    }
}
