using CalculoJuros.Domain.Calculo.Dtos;

namespace CalculoJuros.Domain.Calculo.Interfaces
{
    public interface ICalculoService
    {
        CalcularJurosResponse CalcularJurosCompostos(CalcularJurosRequest calcularJurosRequest);
    }
}