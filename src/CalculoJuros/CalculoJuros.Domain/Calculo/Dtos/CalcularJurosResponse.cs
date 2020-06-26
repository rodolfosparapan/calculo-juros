namespace CalculoJuros.Domain.Calculo.Dtos
{
    public class CalcularJurosResponse
    {
        public CalcularJurosResponse(decimal valorFinal, string taxaJurosDescricao)
        {
            ValorFinal = valorFinal;
            Mensagem = "Taxa de juros utilizada no calculo: " + taxaJurosDescricao;
        }

        public decimal ValorFinal { get; set; }
        public string Mensagem { get; set; }
    }
}