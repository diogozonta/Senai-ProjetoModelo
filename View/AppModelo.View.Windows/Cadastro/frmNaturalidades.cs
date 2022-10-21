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
    public partial class frmNaturalidades : Form
    {    
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidades()
        {
            InitializeComponent();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var dataCriacao = DateTime.UtcNow.ToString();
            var dataAlteracao = DateTime.UtcNow.ToString();

            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text, dataCriacao, dataAlteracao, true);

            if (salvou)
            {
                MessageBox.Show("Naturalidade cadastrada com sucesso!", "Sucesso" + MessageBoxIcon.Information + MessageBoxButtons.OK);
            }
            
            else
            {
                MessageBox.Show("Erro ao acessar banco de dados!", "Erro" + MessageBoxIcon.Error + MessageBoxButtons.OK);

            }
        }
    }
}
