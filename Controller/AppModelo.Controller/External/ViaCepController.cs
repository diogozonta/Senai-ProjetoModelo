using AppModelo.Model.Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //Retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(string cep)
        {
            var viacep = new ViaCepWrapper();
            //FAKE CONSULTA
            viacep.Bairro = "Aviso";
            viacep.Logradouro = "Filogonio Peixoto";
            viacep.Localidade = "Linhares";
            return viacep;
        }
    }
}
