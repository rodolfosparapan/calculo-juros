using CalculoJuros.Data.Api;
using CalculoJuros.Domain.Calculo.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net.Http;

namespace CalculoJuros.Api.Configuration
{
    public static class RetrySetup
    {
        public static void ConfigRetryPolicy(this IServiceCollection services)
        {
            services.AddHttpClient<ITaxaJurosApi, TaxaJurosApi>()
                  .AddPolicyHandler(GetRetryPolicy());
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions.HandleTransientHttpError()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

        }
    }
}