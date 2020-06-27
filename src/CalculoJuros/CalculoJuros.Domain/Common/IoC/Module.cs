using CalculoJuros.Domain.Calculo;
using CalculoJuros.Domain.Calculo.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculoJuros.Domain.Common.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var result = new Dictionary<Type, Type>
            {
                { typeof(ICalculoService), typeof(CalculoService) }
            };

            return result;
        }
    }
}