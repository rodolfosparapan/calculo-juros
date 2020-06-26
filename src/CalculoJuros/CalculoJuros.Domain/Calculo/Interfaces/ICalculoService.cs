using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Common.Interfaces;
using System.Threading.Tasks;

namespace CalculoJuros.Domain.Calculo.Interfaces
{
    public interface ICalculoService : IService
    {
        Task<CalcularJurosResponse> CalcularJurosCompostosAsync(CalcularJurosRequest calcularJurosRequest);
    }
}