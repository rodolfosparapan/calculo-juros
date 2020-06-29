using CalculoJuros.Api.Controllers;
using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace CalculoJuros.Test.Api
{
    public class CalculaJurosControllerTests
    {
        private readonly ICalculoService calculoService;
        private readonly CalculaJurosController controller;

        public CalculaJurosControllerTests()
        {
            calculoService = Substitute.For<ICalculoService>();

            controller = new CalculaJurosController(calculoService);
        }

        [Fact]
        public async void Deve_Retornar_Juros_Calculado_Com_Sucesso()
        {
            var request = new CalcularJurosRequest()
            {
                ValorInicial = 100,
                Tempo = 5
            };

            calculoService.CalcularJurosCompostosAsync(request).Returns(new CalcularJurosResponse(105.10m, string.Empty));

            var retorno = await controller.GetAsync(request) as OkObjectResult;
            var calculo = retorno.Value as CalcularJurosResponse;

            Assert.Equal(200, retorno.StatusCode);
            Assert.Equal(105.10m, calculo.ValorFinal);
        }

        [Fact]
        public async void Deve_Retornar_Erro_Caso_Requisicao_Seja_Invalida()
        {
            var request = new CalcularJurosRequest()
            {
                ValorInicial = 0,
                Tempo = 0
            };

            calculoService.Invalido.Returns(true);
            var retorno = await controller.GetAsync(request) as BadRequestObjectResult;
            
            Assert.Equal(400, retorno.StatusCode);
        }
    }
}