using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int Id { get; set; }
        public string Nome_Completo { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public bool Sexo { get; set; }
        public string Cpf { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Telefone_Contato { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
    }
}
