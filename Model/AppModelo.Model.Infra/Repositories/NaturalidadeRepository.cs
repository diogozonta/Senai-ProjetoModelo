using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
        public bool Inserir(string descricao, bool ativo)
        {
            string dataCriacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{dataCriacao}', '{dataAlteracao}', '{ativo}')";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        public IEnumerable<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var sql = "SELECT id, descricao, dataCriacao, dataAlteracao FROM naturalidades";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Query(sql);

            return (IEnumerable<NaturalidadeEntity>)resultado;
        }

    }
}
