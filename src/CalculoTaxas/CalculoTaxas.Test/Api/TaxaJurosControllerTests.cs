using CalculoTaxas.Api.Controllers;
using CalculoTaxas.Domain.TaxasJuros.Dtos;
using CalculoTaxas.Domain.TaxasJuros.interfaces;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace CalculoTaxas.Test.Api
{
    public class TaxaJurosControllerTests
    {
        private readonly ITaxaJurosService taxaJurosService;
        private readonly TaxaJurosController controller;

        public TaxaJurosControllerTests()
        {
            taxaJurosService = Substitute.For<ITaxaJurosService>();

            controller = new TaxaJurosController(taxaJurosService);
        }

        [Fact]
        public void Deve_Retornar_Taxa_Fixa_Com_Sucesso()
        {
            taxaJurosService.Obter().Returns(new TaxaJurosResponse { 
                Valor = 1
            });

            var retorno = controller.Get() as OkObjectResult;
            var taxaJuros = retorno.Value as TaxaJurosResponse;

            Assert.Equal(200, retorno.StatusCode);
            Assert.Equal(1, taxaJuros.Valor);
        }
    }
}