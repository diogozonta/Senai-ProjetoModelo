using AppModelo.Controller.Cadastros;
using AppModelo.Model.Domain.Entities;
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
            txtId.Enabled = false;

            gvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var charEhNumero = Helpers.Componentes.CharEhNumero(txtDescricao.Text);

            if(charEhNumero)
            {
                errorProvider1.SetError(txtDescricao,"Naturalidade não pode conter números");
                txtDescricao.Focus();
                return;
            }
           

            string descricao = txtDescricao.Text.ToUpper();

            var salvou = _naturalidadeController.Cadastrar(descricao, chkAtivo.Checked);

        }

    }
}
