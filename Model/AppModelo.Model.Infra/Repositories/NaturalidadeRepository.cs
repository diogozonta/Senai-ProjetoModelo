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
    public class NaturalidadeRepository
    {
        public bool Inserir(string descricao, string dataCriacao, string dataAlteracao, bool ativo)
        {
            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{dataCriacao}', '{dataAlteracao}', '{ativo}')";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
