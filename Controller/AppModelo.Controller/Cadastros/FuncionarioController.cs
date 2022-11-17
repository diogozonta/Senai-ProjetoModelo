using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade, string cpf)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataNascimento, sexo, email, telefone, telefoneContato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade, cpf);
            return resposta;
        }
    }
}
