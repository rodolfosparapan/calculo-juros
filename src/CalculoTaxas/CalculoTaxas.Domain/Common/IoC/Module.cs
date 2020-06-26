using CalculoTaxas.Domain.TaxasJuros;
using CalculoTaxas.Domain.TaxasJuros.interfaces;
using System;
using System.Collections.Generic;

namespace CalculoTaxas.Domain.Common.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var result = new Dictionary<Type, Type>
            {
                { typeof(ITaxaJurosService), typeof(TaxaJurosService) }
            };

            return result;
        }
    }
}