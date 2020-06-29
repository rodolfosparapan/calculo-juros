using CalculoJuros.Domain.Calculo;
using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using System;
using Xunit;

namespace CalculoJuros.Test.Domain.Calculo
{
    public class CaculoServiceTests
    {
        private readonly ITaxaJurosApi taxaJurosApi;
        private readonly CalculoService service;

        public CaculoServiceTests()
        {
            taxaJurosApi = Substitute.For<ITaxaJurosApi>();

            service = new CalculoService(taxaJurosApi);
        }
        
        [Fact]
        public async void Deve_Adicionar_Notificacao_Caso_Requisicao_Seja_Invalida()
        {
            var request = new CalcularJurosRequest()
            {
                ValorInicial = 0,
                Tempo = 0
            };
            
            await service.CalcularJurosCompostosAsync(request);

            Assert.True(service.Invalido);
        }

        [Fact]
        public async void Deve_Adicionar_Notificacao_Caso_Comunicacao_Com_Api_Retorne_Excessao()
        {
            taxaJurosApi.ObterTaxaJurosAsync().Throws<Exception>();

            await service.CalcularJurosCompostosAsync(ObterRequestValido());

            Assert.True(service.Invalido);
        }

        [Fact]
        public async void Deve_Calcular_JurosCompostos_Com_Taxa_Retornada_Api()
        {
            taxaJurosApi.ObterTaxaJurosAsync().Returns(new TaxaJurosApiResponse { 
                Valor = 0.01
            });
            
            var retorno = await service.CalcularJurosCompostosAsync(ObterRequestValido());   
            
            Assert.Equal(105.10m, retorno.ValorFinal);
        }

        private CalcularJurosRequest ObterRequestValido() //105.10
        {
            return new CalcularJurosRequest()
            {
                ValorInicial = 100,
                Tempo = 5
            };
        }
    }
}