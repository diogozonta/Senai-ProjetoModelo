﻿using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
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
    public partial class frmFuncionario : Form
    {
        /// <summary>
        /// Instância a classe FuncionarioController em uma propriedade para utilizá-la onde necessário
        /// </summary>
        private FuncionarioController _funcionarioController = new FuncionarioController();
        /// <summary>
        /// Instância a classe NacionalidadeController em uma propriedade para utilizá-la onde necessário
        /// </summary>
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        /// <summary>
        /// Instância a classe NaturalidadeController em uma propriedade para utilizá-la onde necessário
        /// </summary>
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        /// <summary>
        /// Class <c>frmFuncionario</c> contrutor chamada o metódo FormatarCamposObrigatorios para indicar
        /// o usuário quais os campos são obrigados a preencher.
        /// Também chama o metódo ObterTodasNacionalidades/ObterTodasNaturalidades dentro de uma combo box
        /// </summary>
        public frmFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "Id";


            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNaturalidade.ValueMember = "Id";

        }


        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Classe instanciada
            var cepController = new ViaCepController();

            //Recebo os dados do metódo para obter o endereço
            var endereco = cepController.Obter(txtCep.Text);

            txtBairro.Text = endereco.Bairro;
            txtLogradouro.Text = endereco.Logradouro;
            txtMunicipio.Text = endereco.Localidade;
            txtUf.Text = endereco.Uf;

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            // primeira regra para verificar se o nome é < que 6 letras.
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                btnCadastrarFuncionario.Enabled = false;
                return;
            }

            // verifica se digitou algum número.
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Um nome não pode conter números");
                    btnCadastrarFuncionario.Enabled = false;
                    return;
                }
            }


            btnCadastrarFuncionario.Enabled = true;
            errorProvider.Clear();

        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);

            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF inválido!");
                btnCadastrarFuncionario.Enabled = false;
                return;
            }

            btnCadastrarFuncionario.Enabled = true;
            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "E-mail inválido!");
                btnCadastrarFuncionario.Enabled = false;
                return;
            }

            btnCadastrarFuncionario.Enabled = true;
            errorProvider.Clear();
        }

        private void txtDataNascimento_Validated(object sender, EventArgs e)
        {
            try
            {
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                var dataHoje = DateTime.Now;

                if (dataNascimento > dataHoje)
                {
                    errorProvider.SetError(txtDataNascimento, "Você não pode informar a data de hoje");
                    btnCadastrarFuncionario.Enabled = false;
                    return;
                }

                errorProvider.Clear();
            }
            catch (Exception)
            {
                btnCadastrarFuncionario.Enabled = true;
                return;
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                int numero = int.Parse(txtNumero.Text);

                int idNacionalidade = int.Parse(cmbNacionalidade.GetItemText(cmbNacionalidade.SelectedValue));
                int idNaturalidade = int.Parse(cmbNaturalidade.GetItemText(cmbNaturalidade.SelectedValue));

                var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, rbMasculino.Checked, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtCep.Text, txtLogradouro.Text, numero, txtComplemento.Text, txtBairro.Text, txtMunicipio.Text, txtUf.Text, idNacionalidade, idNaturalidade, txtCpf.Text);  ;

                if (salvou)
                {
                    MessageBox.Show("Cadastrado com sucesso");

                    var txtClear = new LimparTela();

                    txtClear.LimparCampos(this.Controls);


                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Ocorreu algum problema ao cadastrar no banco de dados, verifique os dados colocados novamente. " + e1.Message, "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
