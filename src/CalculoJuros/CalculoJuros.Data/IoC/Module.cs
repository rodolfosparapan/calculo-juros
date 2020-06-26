using CalculoJuros.Data.Repositories;
using CalculoJuros.Data.UoW;
using CalculoJuros.Domain.Common.Interfaces;
using CalculoJuros.Domain.Usuarios.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculoJuros.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var result = new Dictionary<Type, Type>
            {
                { typeof(IUnitOfWork), typeof(UnitOfWork) },
                { typeof(IUsuarioRepository), typeof(UsuarioRepository) }
            };

            return result;
        }
    }
}