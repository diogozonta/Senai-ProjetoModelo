using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        public bool Inserir(string descricao, bool status)
        {
            var agora = DateTime.Now.ToString("u");

            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{agora}', '{agora}', {status})";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        public IEnumerable<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var sql = "SELECT id, descricao, dataCriacao, dataAlteracao, ativo FROM naturalidades";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }

        public NaturalidadeEntity ObterPorDescricao(string descricao, bool status)
        {
            var sql = $"SELECT descricao FROM naturalidades WHERE descricao = '{descricao}'";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado;
        }

    }
}
