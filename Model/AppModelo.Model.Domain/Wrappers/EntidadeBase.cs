using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Wrappers
{
    public abstract class EntidadeBase
    {
        public string Erro { get; set; }
        public bool Sucesso { get; set; }
    }
}
