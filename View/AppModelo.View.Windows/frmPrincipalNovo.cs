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
    public partial class frmPrincipalNovo : Form
    {
        public frmPrincipalNovo()
        {
            InitializeComponent();
            pnlNav.Height = btnNovoFuncionario.Height;
            pnlNav.Top = btnNovoFuncionario.Top;
            pnlNav.Left = btnNovoFuncionario.Left;
            btnNovoFuncionario.BackColor = Color.FromArgb(46, 51, 73);

            lblTitulo.Text = "Funcionário";
            this.pnlPainelAberto.Controls.Clear();
            Cadastros.frmFuncionario frmCadastoFuncionaio = new Cadastros.frmFuncionario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCadastoFuncionaio.FormBorderStyle = FormBorderStyle.None;
            this.pnlPainelAberto.Controls.Add(frmCadastoFuncionaio);
            frmCadastoFuncionaio.Show();
        }

        private void frmPrincipalNovo_Load(object sender, EventArgs e)
        {
            //No load do programa coloco a variável global(que veio do frmLogin) dentro do meu lblNomeUsuario(local do frmPrincipalNovo)
            lblNomeUsuario.Text = frmLogin.SetNomeUsuario;
            lblInfoUsuario.Text = frmLogin.HoraLogin;
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNovoFuncionario.Height;
            pnlNav.Top = btnNovoFuncionario.Top;
            pnlNav.Left = btnNovoFuncionario.Left;
            btnNovoFuncionario.BackColor = Color.FromArgb(46, 51, 73);

            lblTitulo.Text = "Funcionário";
            this.pnlPainelAberto.Controls.Clear();
            Cadastros.frmFuncionario frmCadastoFuncionaio = new Cadastros.frmFuncionario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCadastoFuncionaio.FormBorderStyle= FormBorderStyle.None;
            this.pnlPainelAberto.Controls.Add(frmCadastoFuncionaio);
            frmCadastoFuncionaio.Show();
        }

        private void btnNovaNaturalidade_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNovaNaturalidade.Height;
            pnlNav.Top = btnNovaNaturalidade.Top;
            pnlNav.Left = btnNovaNaturalidade.Left;
            btnNovaNaturalidade.BackColor = Color.FromArgb(46, 51, 73);

            lblTitulo.Text = "Naturalidade";
            this.pnlPainelAberto.Controls.Clear();
            Cadastros.frmNaturalidade frmCadastoFuncionaio = new Cadastros.frmNaturalidade() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCadastoFuncionaio.FormBorderStyle = FormBorderStyle.None;
            this.pnlPainelAberto.Controls.Add(frmCadastoFuncionaio);
            frmCadastoFuncionaio.Show();
        }

        private void btnNovaNacionalidade_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNovaNacionalidade.Height;
            pnlNav.Top = btnNovaNacionalidade.Top;
            pnlNav.Left = btnNovaNacionalidade.Left;
            btnNovaNacionalidade.BackColor = Color.FromArgb(46, 51, 73);

            lblTitulo.Text = "Nacionalidade";
            this.pnlPainelAberto.Controls.Clear();
            Cadastros.frmNacionalidade frmCadastoFuncionaio = new Cadastros.frmNacionalidade() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCadastoFuncionaio.FormBorderStyle = FormBorderStyle.None;
            this.pnlPainelAberto.Controls.Add(frmCadastoFuncionaio);
            frmCadastoFuncionaio.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRelatorio.Height;
            pnlNav.Top = btnRelatorio.Top;
            pnlNav.Left = btnRelatorio.Left;
            btnRelatorio.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnNovoFuncionario_Leave(object sender, EventArgs e)
        {
            btnNovoFuncionario.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNovaNaturalidade_Leave(object sender, EventArgs e)
        {
            btnNovaNaturalidade.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNovaNacionalidade_Leave(object sender, EventArgs e)
        {
            btnNovaNacionalidade.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRelatorio_Leave(object sender, EventArgs e)
        {
            btnRelatorio.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFecharPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
