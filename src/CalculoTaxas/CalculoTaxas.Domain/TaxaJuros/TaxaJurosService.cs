using CalculoTaxas.Domain.TaxasJuros.Dtos;
using CalculoTaxas.Domain.TaxasJuros.interfaces;

namespace CalculoTaxas.Domain.TaxasJuros
{
    internal class TaxaJurosService : ITaxaJurosService
    {
        public TaxaJurosResponse Obter()
        {
            return new TaxaJurosResponse
            {
                TaxaJuros = 0.01d,
                TaxaJurosDescricao = "100 %"
            };
        }
    }
}