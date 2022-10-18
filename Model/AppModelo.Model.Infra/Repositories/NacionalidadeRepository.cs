using AppModelo.Model.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        //CRUD - create - read - update - delete
        public bool Inserir() { }
        public bool Atualizar() { }
        public bool Remover() { }
        public List<NacionalidadeEntity> ObterTodos() 
        {
            var sql = "SELECT * FROM nacionalidades";
        }
        public NacionalidadeEntity ObterPorId() { }
    }                               
}                                   
                                    