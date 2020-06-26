using CalculoJuros.Domain.Calculo.Dtos;
using System.Threading.Tasks;

namespace CalculoJuros.Domain.Calculo.Interfaces
{
    public interface ITaxaJurosApi
    {
        Task<TaxaJurosApiResponse> ObterTaxaJurosAsync();
    }
}