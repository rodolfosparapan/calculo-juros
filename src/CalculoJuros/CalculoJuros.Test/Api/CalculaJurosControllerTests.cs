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
        public async void Deve_Retornar_Ok_Caso_Requisicao_Seja_Valida()
        {
            calculoService.CalcularJurosCompostosAsync(new CalcularJurosRequest()).Returns(new CalcularJurosResponse(1m, string.Empty));

            var retorno = await controller.GetAsync(new CalcularJurosRequest()) as OkObjectResult;
            var calculo = retorno.Value as CalcularJurosResponse;

            Assert.Equal(200, retorno.StatusCode);
        }

        [Fact]
        public async void Deve_Retornar_BadRequest_Caso_Requisicao_Seja_Invalida()
        {
            calculoService.Invalido.Returns(true);
            
            var retorno = await controller.GetAsync(new CalcularJurosRequest()) as BadRequestObjectResult;
            
            Assert.Equal(400, retorno.StatusCode);
        }
    }
}