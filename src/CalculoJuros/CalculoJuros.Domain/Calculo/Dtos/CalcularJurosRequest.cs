using CalculoJuros.Domain.Common;
using CalculoJuros.Domain.Common.Interfaces;
using CalculoJuros.Domain.Common.Resources;
using Flunt.Validations;

namespace CalculoJuros.Domain.Calculo.Dtos
{
    public class CalcularJurosRequest : RequestBase, IRequest
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }

        public void Validate()
        {
            var contract = new Contract();

            contract.IsGreaterThan(ValorInicial, 0, nameof(ValorInicial), string.Format(Traducao.Valor_Campo_x0_Deve_Ser_Maior_Que_x1, nameof(ValorInicial), 0));
            contract.IsGreaterThan(Tempo, 0, nameof(Tempo), string.Format(Traducao.Valor_Campo_x0_Deve_Ser_Maior_Que_x1, nameof(Tempo), 0));

            AddNotifications(contract);
        }
    }
}