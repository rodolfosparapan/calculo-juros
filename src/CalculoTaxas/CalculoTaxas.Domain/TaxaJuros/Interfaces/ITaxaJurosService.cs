using CalculoTaxas.Domain.TaxasJuros.Dtos;

namespace CalculoTaxas.Domain.TaxasJuros.interfaces
{
    public interface ITaxaJurosService
    {
        TaxaJurosResponse Obter();
    }
}