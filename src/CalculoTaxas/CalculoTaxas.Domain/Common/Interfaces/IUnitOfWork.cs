using System;

namespace CalculoTaxas.Domain.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}