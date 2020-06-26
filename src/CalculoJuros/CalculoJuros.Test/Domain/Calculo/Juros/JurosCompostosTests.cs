using CalculoJuros.Domain.Calculo.Juros;
using Xunit;

namespace CalculoJuros.Test.Domain.Calculo.Juros
{
    public class JurosCompostosTests
    {
        [Theory]
        [InlineData(12.32595, 13.88)]
        [InlineData(24.25555, 27.33)]
        [InlineData(48.85245, 55.04)]
        [InlineData(96.45848, 108.69)]
        [InlineData(192.8444, 217.30)]
        public void Deve_Calcular_Juros_E_Truncar_Resultado_Em_2_Casas_Sem_Arredondamento(decimal valorInicial, decimal resultadoEsperado)
        {
            double juros = 0.01;
            int tempo = 12;

            var valorFinal = JurosCompostos.Calcular(valorInicial, juros, tempo);
            
            Assert.Equal(resultadoEsperado, valorFinal);
        }
    }
}