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

namespace AppModelo.View.Windows.Relatorios
{
    public partial class frmRelatorioFuncionario : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
            dgvRelatorioFuncionarios.DataSource = _funcionarioController.ObterTodos();
        }
    }
}
