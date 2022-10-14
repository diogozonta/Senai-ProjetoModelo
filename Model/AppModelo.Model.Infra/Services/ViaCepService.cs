using AppModelo.Model.Domain.Wrappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AppModelo.Model.Infra.Services
{
    public class ViaCepService
    {

        public ViaCepWrapper ObterDaApi(string cep)
        {
            //Como o metodo precisa retornar um ViaCepWrapper, é criada um instancia vazia para retornar ela caso dê erro.
            var cepWrapper = new ViaCepWrapper();

            //Instancia HTTP que permite obter informações da Internet através de uma URL
            using var http = new HttpClient();

            var url = new Uri($"https://viacep.com.br/ws/{cep}/json/");
            var result = http.GetAsync(url).GetAwaiter().GetResult();

            //Caso dê erro na camada ! = da API de Cep retorna o erro.
            if (result.StatusCode != HttpStatusCode.OK)
            {
                cepWrapper.Erro = $"Erro: {result.StatusCode}";
                cepWrapper.Sucesso = false;
                return cepWrapper;
            }

            //Converte o resultado obtido em uma string
            var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            //Converte a string json para nossa classe ViaCepWrapper
            cepWrapper = JsonConvert.DeserializeObject<ViaCepWrapper>(resultContent);
            return cepWrapper;
        }
    }
}
