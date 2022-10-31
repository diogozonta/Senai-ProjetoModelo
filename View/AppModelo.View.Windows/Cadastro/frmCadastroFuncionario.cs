using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Classe instanciada
            var cepController = new ViaCepController();

            //Recebo os dados do metódo para obter o endereço
            var endereco = cepController.Obter(txtCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            // primeira regra para verificar se o nome é < que 6 letras.
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }

            // verifica se digitou algum número.
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Um nome não pode conter números");
                    return;
                }
            }

            errorProvider.Clear();

        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);

            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF inválido!");
                return;
            }
            
            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "E-mail inválido!");
                return;
            }

            errorProvider.Clear();
        }

        private void txtDataNascimento_Validated(object sender, EventArgs e)
        {
            var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            var dataHoje = DateTime.Now;

            if(dataNascimento > dataHoje)
            {
                errorProvider.SetError(txtDataNascimento, "Você não pode informar a data de hoje");
                return;
            }

            errorProvider.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            int numero = int.Parse(txtEnderecoNumero.Text);

            var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, rbMasculino.Checked, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text, 1, 1);

            if (salvou)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário");
            }
        }
    }
}
