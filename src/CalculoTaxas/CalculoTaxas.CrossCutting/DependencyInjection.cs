using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace CalculoTaxas.CrossCutting
{
    public static class DependencyInjection
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterDomainServices(services);
        }

        private static void RegisterDomainServices(IServiceCollection services)
        {
            services.RegisterTypes(Domain.Common.IoC.Module.GetTypes());
        }

        private static void RegisterTypes(this IServiceCollection services, Dictionary<Type, Type> types)
        {
            foreach (var item in types)
            {
                services.AddTransient(item.Key, item.Value);
            }
        }
    }
}