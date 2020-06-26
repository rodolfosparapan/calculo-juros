namespace CalculoJuros.Domain.Calculo.Dtos
{
    public class CalcularJurosResponse
    {
        public CalcularJurosResponse(decimal valorFinal, double juros)
        {
            ValorFinal = valorFinal;
            Mensagem = "Taxa de juros utilizada no calculo: " + juros;
        }

        public decimal ValorFinal { get; set; }
        public string Mensagem { get; set; }
    }
}