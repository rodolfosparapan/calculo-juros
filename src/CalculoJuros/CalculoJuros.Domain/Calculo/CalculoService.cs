using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using CalculoJuros.Domain.Calculo.Juros;
using CalculoJuros.Domain.Common;

namespace CalculoJuros.Domain.Calculo
{
    internal class CalculoService : ServiceBase, ICalculoService
    {
        public CalcularJurosResponse CalcularJurosCompostos(CalcularJurosRequest calcularJurosRequest)
        {
            if (!ValidarRequest(calcularJurosRequest))
            {
                return null;
            }

            var juros = ObterTaxaJuros();

            var valorFinal = JurosCompostos.Calcular(calcularJurosRequest.ValorInicial, juros, calcularJurosRequest.Tempo);

            return new CalcularJurosResponse(valorFinal, juros);
        }

        private double ObterTaxaJuros()
        {
            return 0.01;
        }
    }
}