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
    public class UsuarioRepository
    {
        public UsuarioEntity Obter(string usuario, string senha)
        {
            var sql = $"SELECT email, senha FROM usuarios WHERE email ='{usuario}' AND senha ='{senha}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            
            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }
    }
}
