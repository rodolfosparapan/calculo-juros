using System;

namespace CalculoJuros.Domain.Calculo.Juros
{
    public static class JurosCompostos
    {
        public static decimal Calcular(decimal valorInicial, double juros, int tempo)
        {
            var valorFinal = (double) valorInicial * Math.Pow(1 + juros, tempo);

            return (decimal) Math.Truncate(100 * valorFinal) / 100;
        }
    }
}