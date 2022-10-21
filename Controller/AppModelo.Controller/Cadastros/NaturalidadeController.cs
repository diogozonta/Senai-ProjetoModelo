using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Cadastrar(string descricao, string dataCriacao, string dataAlteracao, bool ativo)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Inserir(descricao, dataCriacao, dataAlteracao, ativo);
            return resposta;
        }
    }
}
