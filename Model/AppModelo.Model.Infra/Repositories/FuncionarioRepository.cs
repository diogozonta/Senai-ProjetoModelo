using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Inserir(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (nome_completo, data_nascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, fk_nacionalidade, fk_naturalidade) VALUES ('{nome}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
