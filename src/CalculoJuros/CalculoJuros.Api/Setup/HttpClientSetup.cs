using CalculoJuros.Data.Api;
using CalculoJuros.Domain.Calculo.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net.Http;

namespace CalculoJuros.Api.Setup
{
    public static class HttpClientSetup
    {
        public static void AddHttpClientSetup(this IServiceCollection services, IConfiguration configuration)
        {
            var urlTaxaJuros = configuration.GetSection("Apis:TaxaJuros:UrlBase").Value;
            services.AddHttpClient<ITaxaJurosApi, TaxaJurosApi>(c =>
            {
                c.BaseAddress = new Uri(urlTaxaJuros);
            })
            .AddPolicyHandler(GetRetryPolicy());
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions.HandleTransientHttpError()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

        }
    }
}