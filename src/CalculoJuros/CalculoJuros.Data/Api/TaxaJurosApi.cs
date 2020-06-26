using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculoJuros.Data.Api
{
    public class TaxaJurosApi : ITaxaJurosApi
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;

        public TaxaJurosApi(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }

        public async Task<TaxaJurosApiResponse> ObterTaxaJurosAsync()
        {
            var uri = configuration.GetSection("Apis:TaxaJuros:Obter").Value;

            var retornoApi = await httpClient.GetAsync(uri);
            var retornoConteudo = await retornoApi.Content.ReadAsStringAsync();

            return ObterRetornoApi(retornoApi, retornoConteudo);
        }

        private static TaxaJurosApiResponse ObterRetornoApi(HttpResponseMessage retornoApi, string retornoConteudo)
        {
            var taxaJuros = new TaxaJurosApiResponse();
            if (retornoApi.StatusCode == HttpStatusCode.OK)
            {
                taxaJuros = JsonConvert.DeserializeObject<TaxaJurosApiResponse>(retornoConteudo);
                taxaJuros.Sucesso = true;
            }

            return taxaJuros;
        }
    }
}