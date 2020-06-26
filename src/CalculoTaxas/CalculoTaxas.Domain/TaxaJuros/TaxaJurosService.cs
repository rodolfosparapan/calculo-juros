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
                Valor = 0.01d,
                Descricao = "100 %"
            };
        }
    }
}