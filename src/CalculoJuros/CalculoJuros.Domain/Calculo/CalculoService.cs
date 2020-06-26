using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using CalculoJuros.Domain.Calculo.Juros;
using CalculoJuros.Domain.Common;
using System;
using System.Threading.Tasks;

namespace CalculoJuros.Domain.Calculo
{
    internal class CalculoService : ServiceBase, ICalculoService
    {
        private readonly ITaxaJurosApi taxaJurosApi;

        public CalculoService(ITaxaJurosApi taxaJurosApi)
        {
            this.taxaJurosApi = taxaJurosApi;
        }

        public async Task<CalcularJurosResponse> CalcularJurosCompostosAsync(CalcularJurosRequest calcularJurosRequest)
        {
            if (!ValidarRequest(calcularJurosRequest))
            {
                return null;
            }

            var taxaJuros = await ObterTaxaJuros();

            var valorFinal = JurosCompostos.Calcular(calcularJurosRequest.ValorInicial, taxaJuros.Valor, calcularJurosRequest.Tempo);

            return new CalcularJurosResponse(valorFinal, taxaJuros.Descricao);
        }

        private async Task<TaxaJurosApiResponse> ObterTaxaJuros()
        {
            var taxaJuros = new TaxaJurosApiResponse();
            try
            {
                taxaJuros = await taxaJurosApi.ObterTaxaJurosAsync();
            }
            catch(Exception Ex) 
            {
                AdicionarNotificacao("taxaJuros", "Erro ao obter taxa de juros. Ex: " + Ex.Message);
            }
            
            return taxaJuros;
        }
    }
}