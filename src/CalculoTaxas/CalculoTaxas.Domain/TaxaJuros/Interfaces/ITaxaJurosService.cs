using CalculoTaxas.Domain.Common.Interfaces;
using CalculoTaxas.Domain.TaxasJuros.Dtos;

namespace CalculoTaxas.Domain.TaxasJuros.interfaces
{
    public interface ITaxaJurosService : IService
    {
        TaxaJurosResponse Obter();
    }
}